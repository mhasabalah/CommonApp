var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddBlazoredToast();

//builder.Services.AddInstallerFromReferancedAssemblies(builder.Configuration, typeof(Program).Assembly, "*.Client.dll");
//builder.AddInstallerFromAssemblies(typeof(Program).Assembly);

builder.Services.ConfigureFluentValidationServices();
builder.Services.ConfigureAuthentication(builder.HostEnvironment);
builder.Services.ConfigureHttpServices();
builder.Services.ConfigureRadzen();
builder.Services.AddBlazoredToast();
builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

builder.Services.AddSingleton<AppObserver>();

await builder.Build().RunAsync();
