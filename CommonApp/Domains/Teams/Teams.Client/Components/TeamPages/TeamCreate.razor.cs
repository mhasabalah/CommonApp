namespace Teams.Client.TeamPages;
public partial class TeamCreate
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserverTeam _appObserver { get; set; }

    private ModalForm modal { get; set; }

    TeamViewModel team = new();
    private string url = "api/teams";
    private string formId = "AddTeam";

    private async Task Create()
    {
        await _http.PostAsJsonAsync(url, team);
        team = new();
        _appObserver.TeamHasChanged();

        modal.Close();
    }
}