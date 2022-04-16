namespace Sales.Client.SalePages;
public partial class SaleEdit
{
    [Parameter] public SaleViewModel? Sale { get; set; }

    [Inject] public AppObserver _appObserver { get; set; }
    [Inject] public HttpClient _http { get; set; }
    
    private ModalForm modal { get; set; }
    private const string url = $"api/Sales";
    private string formId = $"EditSale{Guid.NewGuid()}";

    private async Task Edit()
    {
        await _http.PutAsJsonAsync($"{url}", Sale);
        _appObserver.SaleHasChanged();

        modal.Close();
    }
}