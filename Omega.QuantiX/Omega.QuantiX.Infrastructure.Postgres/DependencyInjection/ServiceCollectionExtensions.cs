using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Omega.QuantiX.Infrastructure.Postgres.Persistence;

namespace Omega.QuantiX.Infrastructure.Postgres.DependencyInjection;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddQuantiXContext(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ProductsContext>(options =>
        {
            options
                .UseNpgsql(configuration.GetConnectionString("Postgres:Products"))
                .UseSnakeCaseNamingConvention();
        });
        
        return services;
    }
}