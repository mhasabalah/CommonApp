namespace Sales.Server;
public class SaleServerBuilder : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ISaleRepository, SaleRepository>();
        //services.AddScoped<ISaleValidator, SaleValidator>();
        services.AddScoped<ISaleUnitOfWork, SaleUnitOfWork>();
    }
}