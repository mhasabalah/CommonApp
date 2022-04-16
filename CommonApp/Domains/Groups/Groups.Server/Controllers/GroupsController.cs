namespace Groups.Server;

[Route("api/[controller]")]
[ApiController]
public class GroupsController : BaseSettingsController<Group,GroupViewModel>
{
    public GroupsController(IBaseSettingsUnitOfWork<Group, GroupViewModel> unitOfWork) : base(unitOfWork) { }
}