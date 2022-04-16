namespace Teams.Shared;
public class TeamValidator : BaseSettingsValidator<TeamViewModel>
{
    public TeamValidator():base()
    {
        
        RuleFor(e => e.Name).NotNull().NotEmpty()
                              .WithMessage($"{nameof(TeamViewModel)}  Name is required");
    }
}