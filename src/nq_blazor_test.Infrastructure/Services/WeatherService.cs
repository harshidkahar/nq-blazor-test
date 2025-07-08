using ErrorOr;
using FluentValidation;
using nq_blazor_test.Application.Interfaces;
using nq_blazor_test.Domain.Entities;

namespace nq_blazor_test.Infrastructure.Services;

public class WeatherService : IWeatherService
{
    private readonly IValidator<WeatherCondition> _validator;

    public WeatherService(IValidator<WeatherCondition> validator)
    {
        _validator = validator;
    }

    public Task<ErrorOr<List<WeatherCondition>>> GetWeatherAsync()
    {
        var data = new List<WeatherCondition>
        {
            new() { Date = DateTime.Now, TemperatureC = -5, Summary = "Freezing", Location = "Alaska" },
            new() { Date = DateTime.Now, TemperatureC = 40, Summary = "Scorching", Location = "Dubai" },
            new() { Date = DateTime.Now, TemperatureC = 25, Summary = "Mild", Location = "Paris" },
            new() { Date = DateTime.Now, TemperatureC = -2, Summary = "Bracing", Location = "Moscow" },
            new() { Date = DateTime.Now, TemperatureC = 35, Summary = "Sweltering", Location = "Delhi" }
        };

        var results = new List<WeatherCondition>();

        foreach (var entry in data)
        {
            var validation = _validator.Validate(entry);
            if (!validation.IsValid)
            {
                return Task.FromResult<ErrorOr<List<WeatherCondition>>>(
                    validation.Errors.Select(e => Error.Validation(e.ErrorCode, e.ErrorMessage)).ToList()
                );
            }

            results.Add(entry);
        }

        return Task.FromResult<ErrorOr<List<WeatherCondition>>>(results);
    }
}
