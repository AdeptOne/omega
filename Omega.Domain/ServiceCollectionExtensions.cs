using Microsoft.Extensions.DependencyInjection;
using Omega.Domain.Common.Interfaces;

namespace Omega.Domain;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddDomainServices(this IServiceCollection services)
    {
        services.AddScoped<IProductRepository>();
        
        return services;
    }
}