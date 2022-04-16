namespace Groups.Server;
public class GroupRepository : BaseSettingsRepository<Group>, IGroupRepository
{
    public GroupRepository(ApplicationContext context) : base(context) { }
}