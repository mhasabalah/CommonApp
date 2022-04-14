namespace Employees.Server; 
public class EmployeeUnitOfWork : BaseSettingsUnitOfWork<Employee, EmployeeViewModel>, IEmployeeUnitOfWork
{
    public EmployeeUnitOfWork(IBaseSettingsRepository<Employee> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}

