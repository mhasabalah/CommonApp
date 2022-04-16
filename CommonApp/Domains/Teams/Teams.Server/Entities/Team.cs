namespace Teams.Server;
public class Team : BaseSettingsEntity
{
    public string TeamColor { get; set; }

    public List<Employee> Employees { get; set; }
}