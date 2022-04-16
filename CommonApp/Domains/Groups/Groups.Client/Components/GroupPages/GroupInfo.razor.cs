using Groups.Client.Shared;

namespace Groups.Client.GroupPages;
public partial class GroupInfo
{
    [Parameter] public GroupViewModel? Group { get; set; }
    private ModalForm modal { get; set; }

    private void CloseForm() => modal.Close();
}