namespace Teams.Client;
public class AppObserverTeam
{
    public Action OnTeamChanged { get; set; }
    
    public void TeamHasChanged() => OnTeamChanged?.Invoke();
}
