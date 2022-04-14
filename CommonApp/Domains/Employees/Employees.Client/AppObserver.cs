namespace Employees.Client;
public class AppObserver
{
    public Action OnEmployeeChanged { get; set; }
    
    public void EmployeeHasChanged() => OnEmployeeChanged?.Invoke();
}
