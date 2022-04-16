namespace Teams.Server;
public class TeamServerBuilder : IInstaller
{
    public void ConfigureServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddScoped<ITeamRepository, TeamRepository>();
        //services.AddScoped<ITeamValidator, TeamValidator>();
        services.AddScoped<ITeamUnitOfWork, TeamUnitOfWork>();
    }
}