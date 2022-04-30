namespace CommonApp.Client;
public static class ServiceExtention
{
    public static void ConfigureFluentValidationServices(this IServiceCollection services)
    {
        services.AddLocalization();
        services.AddScoped(typeof(IBaseLocalizer<,>), typeof(BaseLocalizer<,>));
        services.AddScoped<IValidator<EmployeeViewModel>, EmployeeValidator>();
        services.AddScoped<IValidator<TeamViewModel>, TeamValidator>();
        services.AddScoped<IValidator<GroupViewModel>, GroupValidator>();
    }
    public static void ConfigureAuthentication(this IServiceCollection services, IWebAssemblyHostEnvironment hostEnvironment)
    {
        services.AddOptions();
        services.AddAuthorizationCore();
        services.AddScoped<IdentityAuthenticationStateProvider>();
        services.AddScoped<AuthenticationStateProvider>(s => s.GetRequiredService<IdentityAuthenticationStateProvider>());
        services.AddScoped<IAuthorizeApi, AuthorizeApi>();
    }
    public static void ConfigureHttpServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IHttpService<>), typeof(HttpService<>));
        services.AddHttpClientInterceptor();
    }

    public static void ConfigureRadzen(this IServiceCollection services)
    {
        services.AddScoped<DialogService>();
        services.AddScoped<NotificationService>();
        services.AddScoped<TooltipService>();
        services.AddScoped<ContextMenuService>();
    }
}