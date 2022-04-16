using Groups.Client.Shared;

namespace Groups.Client.GroupPages;
public partial class GroupCreate
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public GroupsAppObserver _appObserver { get; set; }

    private ModalForm modal { get; set; }

    GroupViewModel group = new();
    private string url = "api/groups";
    private string formId = "AddGroup";

    private async Task Create()
    {
        await _http.PostAsJsonAsync(url, group);
        group = new();
        _appObserver.GroupHasChanged();

        modal.Close();
    }
}