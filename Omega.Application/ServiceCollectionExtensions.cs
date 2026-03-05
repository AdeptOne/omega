using Microsoft.Extensions.DependencyInjection;

namespace Omega.Application;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        return services;
    }
}