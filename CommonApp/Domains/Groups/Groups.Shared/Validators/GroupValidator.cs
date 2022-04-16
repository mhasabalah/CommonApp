namespace Groups.Shared;
public class GroupValidator : BaseSettingsValidator<GroupViewModel>
{
    public GroupValidator():base()
    {
        RuleFor(e => e.Name).NotNull().NotEmpty()
                              .WithMessage($"{nameof(GroupViewModel)}  Name is required");
    }
}