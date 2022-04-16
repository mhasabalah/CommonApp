using Teams.Client;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");
//builder.Services.AddInstallerFromReferancedAssemblies(builder.Configuration, typeof(Program).Assembly, "*.Client.dll");

builder.Services.ConfigureFluentValidationServices();
builder.Services.ConfigureAuthentication(builder.HostEnvironment);
builder.Services.ConfigureHttpServices();
builder.Services.ConfigureRadzen();
builder.Services.AddBlazoredToast();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddScoped<AppObserver>();
builder.Services.AddScoped<AppObserverTeam>();
await builder.Build().RunAsync();
