namespace Sales.Client;
public partial class SalesForm :IDisposable
{
    [Inject] public HttpClient _http { get; set; }
    [Inject] public AppObserver _appObserver { get; set; }

    string SearchTerm { get; set; } = string.Empty;

    private List<SaleViewModel>? sales;

    private string url = "api/sales";

    private IEnumerable<SaleViewModel> FilteredSales
        => (sales ?? new List<SaleViewModel>())
            .Where(e => e.Name != null && e.Name.ToLower().Contains(SearchTerm.ToLower())).ToList();

    protected override async Task OnInitializedAsync()
    {
        _appObserver.OnSaleChanged += InvokeStateHasChanged();

        await LoadSales();
    }

    public Action InvokeStateHasChanged() => (() =>
    {
        Task.Run(async () =>
        {
            await LoadSales();
            StateHasChanged();
        });
    });

    private async Task LoadSales() => sales = await _http.GetFromJsonAsync<List<SaleViewModel>>(url);

    private void Clear() => SearchTerm = string.Empty;

    private async Task DeleteSale(Guid? id)
    {
        var deleteUrl = $"{url}/{id}";
        await _http.DeleteAsync(deleteUrl);
        sales = await _http.GetFromJsonAsync<List<SaleViewModel>>(url);
    }

    public void Dispose() => _appObserver.OnSaleChanged -= InvokeStateHasChanged();

}
