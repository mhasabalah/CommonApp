namespace Groups.Shared;

public class GroupValidator : BaseSettingsValidator<GroupViewModel, GroupResources>
{
    public GroupValidator(IBaseLocalizer<GroupViewModel, GroupResources> localizer) : base(localizer) { }
}