using Microsoft.Extensions.DependencyInjection;
using nq_blazor_test.Application.Interfaces;
using nq_blazor_test.Infrastructure.Services;

namespace nq_blazor_test.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddScoped<IWeatherService, WeatherService>();
        return services;
    }
}
