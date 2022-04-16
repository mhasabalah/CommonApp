namespace Groups.Server;
public class GroupServerBuilder : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<IGroupRepository, GroupRepository>();
        //services.AddScoped<IGroupValidator, GroupValidator>();
        services.AddScoped<IGroupUnitOfWork, GroupUnitOfWork>();
    }
}