namespace Sales.Client;
public class AppObserver
{
    public Action OnSaleChanged { get; set; }
    
    public void SaleHasChanged() => OnSaleChanged?.Invoke();
}
