global using dffoo.Client.Services.ChampionsService;
global using dffoo.Client.Services.UserService;
global using dffoo.Shared;
using dffoo.Client;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IChampService, ChampService>();
builder.Services.AddScoped<IUserService, UserService>();

await builder.Build().RunAsync();
