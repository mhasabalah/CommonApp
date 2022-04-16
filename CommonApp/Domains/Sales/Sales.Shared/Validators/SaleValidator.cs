namespace Sales.Shared;
public class SaleValidator : BaseSettingsValidator<SaleViewModel>
{
    public SaleValidator():base()
    {
        RuleFor(e => e.Age).GreaterThanOrEqualTo(15)
                           .WithMessage($"{nameof(SaleViewModel)} Age should be Greater Than Or Equal To 15");

        RuleFor(e => e.Mobile).NotNull().NotEmpty()
                              .WithMessage($"{nameof(SaleViewModel)}  Mobile is required");

        RuleFor(e => e.Mobile).MaximumLength(50)
                              .WithMessage($"{nameof(SaleViewModel)}  Mobile MaximumLength is 50");

        RuleFor(e => e.BirthDate).NotNull().NotEmpty()
                                 .WithMessage($"{nameof(SaleViewModel)}  BirthDate is required");
    }
}