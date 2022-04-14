namespace Employees.Server;

[Route("api/[controller]")]
[ApiController]
public class EmployeesController : BaseSettingsController<Employee,EmployeeViewModel>
{
    public EmployeesController(IBaseSettingsUnitOfWork<Employee, EmployeeViewModel> unitOfWork, IValidator<EmployeeViewModel> validator) : base(unitOfWork, validator)
    {
    }
}