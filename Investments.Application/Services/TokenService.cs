using Investments.Application.Interfaces;
using Investments.Domain.Entities;
using Investments.Domain.Interfaces;

namespace Investments.Application.Services
{
    public class TokenService : ITokenService
    {
        private readonly ITokenRepository _tokenRepository;

        public TokenService(ITokenRepository tokenRepository)
        {
            _tokenRepository = tokenRepository;
        }

        public async Task<Guid> CreateAsync(Token token)
        {
            token.Id = Guid.NewGuid();

            return await _tokenRepository.CreateAsync(token);
        }

        public async Task<IEnumerable<Token>> RetrieveAsync()
        {
            return await _tokenRepository.RetrieveAsync();
        }
    }
}
