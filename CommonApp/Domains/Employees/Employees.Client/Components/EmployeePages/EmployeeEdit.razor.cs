namespace Employees.Client.EmployeePages;
public partial class EmployeeEdit
{
    [Parameter] public EmployeeViewModel? Employee { get; set; }

    [Inject] public AppObserver _appObserver { get; set; }
    [Inject] public HttpClient _http { get; set; }
    
    private ModalForm modal { get; set; }
    private const string url = $"api/Employees";
    private string formId = $"EditEmployee{Guid.NewGuid()}";

    private async Task Edit()
    {
        await _http.PutAsJsonAsync($"{url}", Employee);
        _appObserver.EmployeeHasChanged();

        modal.Close();
    }
}