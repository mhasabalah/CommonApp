namespace Sales.Server; 
public class SaleUnitOfWork : BaseSettingsUnitOfWork<Sale, SaleViewModel>, ISaleUnitOfWork
{
    public SaleUnitOfWork(IBaseSettingsRepository<Sale> repository, IMapper mapper) : base(repository, mapper)
    {
    }
}

