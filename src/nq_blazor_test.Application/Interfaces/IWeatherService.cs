using ErrorOr;
using nq_blazor_test.Domain.Entities;

namespace nq_blazor_test.Application.Interfaces;

public interface IWeatherService
{
    Task<ErrorOr<List<WeatherCondition>>> GetWeatherAsync();
}
