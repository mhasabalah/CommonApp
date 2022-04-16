namespace Sales.Shared;
public class SaleViewModel: BaseSettingsViewModel
{
    public string? Region { get; set; }
    public DateTime Date { get; set; }
    public double Sum { get; set; }
}