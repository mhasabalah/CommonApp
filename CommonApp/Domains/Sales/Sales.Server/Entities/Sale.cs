namespace Sales.Server;
public class Sale : BaseSettingsEntity
{
    public string? Region { get; set; }
    public string? Country { get; set; }
    public string? Code { get; set; }
    public string? StoreId { get; set; }
    public DateTime TransactionDate { get; set; }
    public int TransactionId { get; set; }
    public string? ProductGroup { get; set; }
    public double Amount { get; set; }
    public int PromotionId { get; set; }
    public int CustomerInfo { get; set; }
    public string? PaymentType { get; set; }
}