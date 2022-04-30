namespace Teams.Client.TeamPages;
public partial class TeamEdit
{
    [Parameter] public TeamViewModel? Team { get; set; }

    [Inject] public AppObserver _appObserver { get; set; }
    [Inject] public HttpClient _http { get; set; }
    
    private ModalForm modal { get; set; }
    private const string url = $"api/Teams";
    private string formId = $"EditTeam{Guid.NewGuid()}";

    private async Task Edit()
    {
        await _http.PutAsJsonAsync($"{url}", Team);
        _appObserver.SelectedNodeHasChanged();

        modal.Close();
    }
}