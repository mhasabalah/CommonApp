namespace Employees.Client;
public partial class EmployeesForm :IDisposable
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    string SearchTerm { get; set; } = string.Empty;

    private List<EmployeeViewModel>? employees;

    private string url = "api/employees";

    private IEnumerable<EmployeeViewModel> FilteredEmployees
        => (employees ?? new List<EmployeeViewModel>())
            .Where(e => e.Name != null && e.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();

    protected override async Task OnInitializedAsync()
    {
        _appObserver.OnSelectedNodeChanged += InvokeStateHasChanged();

        await LoadEmployees();
    }

    public Action InvokeStateHasChanged() => (() =>
    {
        Task.Run(async () =>
        {
            await LoadEmployees();
            StateHasChanged();
        });
    });

    private async Task LoadEmployees() => employees = await _http.GetFromJsonAsync<List<EmployeeViewModel>>(url);

    private void Clear() => SearchTerm = string.Empty;

    private async Task DeleteEmployee(Guid? id)
    {
        var deleteUrl = $"{url}/{id}";
        await _http.DeleteAsync(deleteUrl);
        employees = await _http.GetFromJsonAsync<List<EmployeeViewModel>>(url);
    }

    public void Dispose() => _appObserver.OnSelectedNodeChanged -= InvokeStateHasChanged();

}
