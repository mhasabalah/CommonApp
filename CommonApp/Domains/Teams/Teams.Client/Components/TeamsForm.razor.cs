namespace Teams.Client;
public partial class TeamsForm :IDisposable
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    string SearchTerm { get; set; } = string.Empty;

    private List<TeamViewModel>? teams;

    private string url = "api/teams";

    private IEnumerable<TeamViewModel> FilteredTeams
        => (teams ?? new List<TeamViewModel>())
            .Where(e => e.Name != null && e.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();

    protected override async Task OnInitializedAsync()
    {
        _appObserver.OnSelectedNodeChanged += InvokeStateHasChanged();

        await LoadTeams();
    }

    public Action InvokeStateHasChanged() => (() =>
    {
        Task.Run(async () =>
        {
            await LoadTeams();
            StateHasChanged();
        });
    });

    private async Task LoadTeams() => teams = await _http.GetFromJsonAsync<List<TeamViewModel>>(url);

    private void Clear() => SearchTerm = string.Empty;

    private async Task DeleteTeam(Guid? id)
    {
        //CityViewModel = await _cityHttpService.DeleteAsync($"/api/cities/{CityViewModel.Id}");
        //successMessage = "City Deleted Successfuly";
        var deleteUrl = $"{url}/{id}";
        await _http.DeleteAsync(deleteUrl);
        teams = await _http.GetFromJsonAsync<List<TeamViewModel>>(url);
    }

    public void Dispose() => _appObserver.OnSelectedNodeChanged -= InvokeStateHasChanged();

}
