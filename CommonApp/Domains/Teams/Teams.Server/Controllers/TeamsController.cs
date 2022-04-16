namespace Teams.Server;

[Route("api/[controller]")]
[ApiController]
public class TeamsController : BaseSettingsController<Team,TeamViewModel>
{
    public TeamsController(IBaseSettingsUnitOfWork<Team, TeamViewModel> unitOfWork) : base(unitOfWork) { }
}