namespace Employees.Server;
public class EmployeeRepository : BaseSettingsRepository<Employee>, IEmployeeRepository
{
    public EmployeeRepository(ApplicationContext context) : base(context) { }
}