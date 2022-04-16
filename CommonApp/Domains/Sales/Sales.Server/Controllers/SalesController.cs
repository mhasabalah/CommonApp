namespace Sales.Server;

[Route("api/[controller]")]
[ApiController]
public class SalesController : BaseSettingsController<Sale,SaleViewModel>
{
    public SalesController(IBaseSettingsUnitOfWork<Sale, SaleViewModel> unitOfWork) : base(unitOfWork) { }
}