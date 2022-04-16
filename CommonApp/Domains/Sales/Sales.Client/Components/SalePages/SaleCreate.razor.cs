namespace Sales.Client.SalePages;
public partial class SaleCreate
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    private ModalForm modal { get; set; }

    SaleViewModel sale = new();
    private string url = "api/sales";
    private string formId = "AddSale";

    private async Task Create()
    {
        await _http.PostAsJsonAsync(url, sale);
        sale = new();
        _appObserver.SaleHasChanged();

        modal.Close();
    }
}