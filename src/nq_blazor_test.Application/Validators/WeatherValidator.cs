using FluentValidation;
using nq_blazor_test.Domain.Entities;

namespace nq_blazor_test.Application.Validators;

public class WeatherConditionValidator : AbstractValidator<WeatherCondition>
{
    public WeatherConditionValidator()
    {
        RuleFor(x => x.Summary)
            .NotEmpty()
            .Must(summary => new[] { "Freezing", "Bracing", "Sweltering", "Scorching", "Mild" }.Contains(summary))
            .WithMessage("Invalid summary.");

        RuleFor(x => x.Location)
            .NotEmpty()
            .WithMessage("Location is required.");
    }
}
