using Investments.Domain.Entities;

namespace Investments.Domain.Interfaces
{
    public interface ITokenRepository
    {
        Task<Guid> CreateAsync(Token token);
        Task<IEnumerable<Token>> RetrieveAsync();
    }
}
