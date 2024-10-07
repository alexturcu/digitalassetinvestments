using Investments.Domain.Entities;

namespace Investments.Application.Interfaces
{
    public interface ITokenService
    {
        Task<Guid> CreateAsync(Token token);
        Task<IEnumerable<Token>> RetrieveAsync();
    }
}
