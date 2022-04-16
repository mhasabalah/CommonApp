namespace Groups.Client;
public class GroupsAppObserver
{
    public Action OnGroupChanged { get; set; }
    
    public void GroupHasChanged() => OnGroupChanged?.Invoke();
}
