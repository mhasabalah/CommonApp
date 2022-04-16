namespace Teams.Server; 
public class TeamUnitOfWork : BaseSettingsUnitOfWork<Team, TeamViewModel>, ITeamUnitOfWork
{
    public TeamUnitOfWork(IBaseSettingsRepository<Team> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}

