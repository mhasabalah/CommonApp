namespace Employees.Client.EmployeePages;
public partial class EmployeeCreate
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    private ModalForm modal { get; set; }

    EmployeeViewModel employee = new();
    private string url = "api/employees";
    private string formId = "AddEmployee";

    private async Task Create()
    {
        await _http.PostAsJsonAsync(url, employee);
        employee = new();
        _appObserver.SelectedNodeHasChanged();

        modal.Close();
    }
}