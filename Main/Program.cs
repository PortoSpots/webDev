using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using MudBlazor.Services;
using porto_spots;
using porto_spots.Main;
using System;
using System.Net.Http;
using porto_spots.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
var httpClient = new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) };
GitFetcher.Initialize(httpClient);
builder.Services.AddScoped(sp => httpClient);
builder.Services.AddMudServices();

await builder.Build().RunAsync();
