using Microsoft.Extensions.DependencyInjection;

namespace AzureFunctionsHealthChecks;

public static class HealthCheckExtensions
{
    public static IServiceCollection AddAzureFunctionsHealthChecks(this IServiceCollection services)
    {        
        services.AddSingleton<HealthCheckFunction>();
        return services;
    }
}

