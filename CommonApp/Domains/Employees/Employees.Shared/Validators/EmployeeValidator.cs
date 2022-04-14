namespace Employees.Shared;
public class EmployeeValidator : BaseSettingsValidator<EmployeeViewModel, EmployeeResources>, IEmployeeValidator
{
    public EmployeeValidator(IBaseLocalizer<EmployeeViewModel, EmployeeResources> localizer) : base(localizer)
    {
        RuleFor(e => e.Age).GreaterThanOrEqualTo(15)
                           .WithMessage($"{nameof(EmployeeViewModel)} Age should be Greater Than Or Equal To 15");

        RuleFor(e => e.Mobile).NotNull().NotEmpty()
                              .WithMessage($"{nameof(EmployeeViewModel)}  Mobile is required");

        RuleFor(e => e.Mobile).MaximumLength(50)
                              .WithMessage($"{nameof(EmployeeViewModel)}  Mobile MaximumLength is 50");

        RuleFor(e => e.BirthDate).NotNull().NotEmpty()
                                 .WithMessage($"{nameof(EmployeeViewModel)}  BirthDate is required");
    }
}