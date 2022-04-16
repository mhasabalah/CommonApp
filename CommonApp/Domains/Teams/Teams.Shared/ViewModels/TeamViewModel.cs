using Employees.Shared;

namespace Teams.Shared;
public class TeamViewModel : BaseSettingsViewModel
{
    public string TeamColor { get; set; }
    public List<EmployeeViewModel> Employees { get; set; }

}