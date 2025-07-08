namespace nq_blazor_test.Domain.Entities;

public sealed class WeatherCondition
{
    public DateTime Date { get; set; }
    public int TemperatureC { get; set; }
    public string Summary { get; set; } = string.Empty;
    public string Location { get; set; } = string.Empty;
}

