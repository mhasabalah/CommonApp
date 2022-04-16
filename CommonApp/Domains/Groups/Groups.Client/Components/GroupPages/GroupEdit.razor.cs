using Groups.Client.Shared;

namespace Groups.Client.GroupPages;
public partial class GroupEdit
{
    [Parameter] public GroupViewModel? Group { get; set; }

    [Inject] public GroupsAppObserver _appObserver { get; set; }
    [Inject] public HttpClient _http { get; set; }
    
    private ModalForm modal { get; set; }
    private const string url = $"api/Groups";
    private string formId = $"EditGroup{Guid.NewGuid()}";

    private async Task Edit()
    {
        await _http.PutAsJsonAsync($"{url}", Group);
        _appObserver.GroupHasChanged();

        modal.Close();
    }
}