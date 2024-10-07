using Investments.Domain.Interfaces;
using Investments.Infrastructure.Data;
using Investments.Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace Investments.Infrastructure.Helpers
{
    public static class PersistenceHelper
    {
        public static void AddPersistence(this IServiceCollection services, string connectionString)
        {
            services.AddDbContext<ApplicationDbContext>(options =>
            {
                options.UseNpgsql(connectionString);
            });

            services.AddScoped<ITokenRepository, TokenRepository>();
        }
    }
}
