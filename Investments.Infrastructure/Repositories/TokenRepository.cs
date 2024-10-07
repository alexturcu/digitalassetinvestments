using Investments.Domain.Entities;
using Investments.Domain.Interfaces;
using Investments.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Investments.Infrastructure.Repositories
{
    public class TokenRepository : ITokenRepository
    {
        private readonly ApplicationDbContext _context;

        public TokenRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Guid> CreateAsync(Token token)
        {
            var existingToken = await _context.Tokens
                .Where(t => t.Name == token.Name && t.DataSource == token.DataSource)
                .FirstOrDefaultAsync();

            if (existingToken != null)
            {
                existingToken.Name = token.Name;
                existingToken.DataSource = token.DataSource;
                existingToken.Quantity = token.Quantity;
                existingToken.Price = token.Price;
            }
            else
            {
                _context.Tokens.Add(token);
            }

            await _context.SaveChangesAsync();

            return token.Id;
        }

        public async Task<IEnumerable<Token>> RetrieveAsync()
        {
            return await _context.Tokens
                .AsNoTracking()
                .ToListAsync();
        }
    }
}
