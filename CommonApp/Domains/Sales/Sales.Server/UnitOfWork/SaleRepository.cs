namespace Sales.Server;
public class SaleRepository : BaseSettingsRepository<Sale>, ISaleRepository
{
    public SaleRepository(ApplicationContext context) : base(context) { }
}