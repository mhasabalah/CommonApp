namespace Teams.Client.TeamPages;
public partial class TeamInfo
{
    [Parameter] public TeamViewModel? Team { get; set; }
    private ModalForm modal { get; set; }

    private void CloseForm() => modal.Close();
}