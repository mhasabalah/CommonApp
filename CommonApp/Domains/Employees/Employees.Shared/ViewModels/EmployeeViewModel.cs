namespace Employees.Shared;
public class EmployeeViewModel: BaseSettingsViewModel
{
    public string? Mobile { get; set; }
    public int Age { get; set; }
    public string? Telephone { get; set; }
    public DateTime? BirthDate { get; set; }
}