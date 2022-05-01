namespace Teams.Client.TeamPages;
public partial class TeamEdit
{
    [Parameter] public TeamViewModel? TeamViewModel { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }
    
    private ModalForm modal { get; set; }
    private string formId = $"EditTeam{Guid.NewGuid()}";

    private async Task Edit()
    {
        await _teamHttpService.PutAsync("/api/Teams", TeamViewModel);
        _toastService.ShowSuccess("Team Edited Successfuly");
        _appObserver.SelectedNodeHasChanged();

        modal.Close();
    }
}