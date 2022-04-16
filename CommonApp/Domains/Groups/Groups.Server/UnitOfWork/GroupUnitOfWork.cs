namespace Groups.Server; 
public class GroupUnitOfWork : BaseSettingsUnitOfWork<Group, GroupViewModel>, IGroupUnitOfWork
{
    public GroupUnitOfWork(IBaseSettingsRepository<Group> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}

