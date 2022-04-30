namespace Groups.Client;
public partial class GroupsForm :IDisposable
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    string SearchTerm { get; set; } = string.Empty;

    private List<GroupViewModel>? groups;

    private string url = "api/groups";

    private IEnumerable<GroupViewModel> FilteredGroups
        => (groups ?? new List<GroupViewModel>())
            .Where(e => e.Name != null && e.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();

    protected override async Task OnInitializedAsync()
    {
        _appObserver.OnSelectedNodeChanged += InvokeStateHasChanged();

        await LoadGroups();
    }

    public Action InvokeStateHasChanged() => (() =>
    {
        Task.Run(async () =>
        {
            await LoadGroups();
            StateHasChanged();
        });
    });

    private async Task LoadGroups() => groups = await _http.GetFromJsonAsync<List<GroupViewModel>>(url);

    private void Clear() => SearchTerm = string.Empty;

    private async Task DeleteGroup(Guid? id)
    {
        var deleteUrl = $"{url}/{id}";
        await _http.DeleteAsync(deleteUrl);
        groups = await _http.GetFromJsonAsync<List<GroupViewModel>>(url);
    }

    public void Dispose() => _appObserver.OnSelectedNodeChanged -= InvokeStateHasChanged();

}
