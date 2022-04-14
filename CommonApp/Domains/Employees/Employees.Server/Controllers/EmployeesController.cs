namespace Employees.Server;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : BaseSettingsController<Employee,EmployeeViewModel>
{
    public EmployeesController(IBaseSettingsUnitOfWork<Employee, EmployeeViewModel> unitOfWork) : base(unitOfWork) { }
}