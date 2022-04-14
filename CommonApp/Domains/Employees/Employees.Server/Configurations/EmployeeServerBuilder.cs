namespace Employees.Server;
public class EmployeeServerBuilder : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IEmployeeRepository, EmployeeRepository>();
        //services.AddScoped<IEmployeeValidator, EmployeeValidator>();
        services.AddScoped<IEmployeeUnitOfWork, EmployeeUnitOfWork>();
    }
}