using FluentValidation;
using Microsoft.Extensions.DependencyInjection;
using nq_blazor_test.Application.Validators;
using nq_blazor_test.Domain.Entities;

namespace nq_blazor_test.Application;

public static class DependencyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddScoped<IValidator<WeatherCondition>, WeatherConditionValidator>();
        return services;
    }
}
