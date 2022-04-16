namespace Teams.Server;
public class TeamRepository : BaseSettingsRepository<Team>, ITeamRepository
{
    public TeamRepository(ApplicationContext context) : base(context) { }
}