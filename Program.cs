using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using StockApp;
using StockApp.Clients;
using Microsoft.AspNetCore.Components.Authorization;

using Blazored.LocalStorage;



var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddAuthorizationCore();
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddHttpClient<StockClient>();

builder.Services.AddBlazoredLocalStorage();
            
await builder.Build().RunAsync();
