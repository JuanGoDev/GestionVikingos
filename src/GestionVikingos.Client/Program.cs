using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using GestionVikingos.Client;
using GestionVikingos.Client.Services;
using GestionVikingos.Client.State;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri("https://localhost:7002") });

builder.Services.AddScoped<VikingoService>();
builder.Services.AddSingleton<VikingosState>();
builder.Services.AddScoped<VikingosManager>();

await builder.Build().RunAsync();
