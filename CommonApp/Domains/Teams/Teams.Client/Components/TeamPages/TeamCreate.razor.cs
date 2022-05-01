namespace Teams.Client.TeamPages;
public partial class TeamCreate
{
    [Inject] public AppObserver _appObserver { get; set; }
    
    [Parameter] public TeamViewModel? TeamViewModel { get; set; } = new();


    private ModalForm modal { get; set; }

    private string formId = "AddTeam";

    private async Task Create()
    {
        await _teamHttpService.PostAsync("api/teams", TeamViewModel);
        _toastService.ShowSuccess("Team Added Successfuly");

        _appObserver.SelectedNodeHasChanged();

        modal.Close();
    }
}