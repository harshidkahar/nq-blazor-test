using ErrorOr;

namespace nq_blazor_test.Domain.Errors;

public static class WeatherErrors
{
    public static Error InvalidSummary =>
        Error.Validation("Weather.InvalidSummary", "Summary is invalid");

    public static Error InvalidLocation =>
        Error.Validation("Weather.InvalidLocation", "Location is required");
}

