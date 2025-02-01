using Append.Blazor.WebShare;
using Blazored.LocalStorage;
using IRL_Levels;
using IRL_Levels.Services.Clipboard;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
builder.Services.AddScoped<IClipboardService, ClipboardService>();

builder.Services.AddBlazoredLocalStorage();
builder.Services.AddWebShare();

await builder.Build().RunAsync();
