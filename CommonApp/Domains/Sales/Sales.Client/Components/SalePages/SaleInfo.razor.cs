namespace Sales.Client.SalePages;
public partial class SaleInfo
{
    [Parameter] public SaleViewModel? Sale { get; set; }
    private ModalForm modal { get; set; }

    private void CloseForm() => modal.Close();
}