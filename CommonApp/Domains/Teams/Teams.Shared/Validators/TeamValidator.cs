namespace Teams.Shared;
public class TeamValidator : BaseSettingsValidator<TeamViewModel, TeamResources>
{
    public TeamValidator(IBaseLocalizer<TeamViewModel, TeamResources> localizer) : base(localizer) { }
}