using Blazored.Modal;
using MatBlazor;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Radzen;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.Configuration["HttpClient:BaseAddress"]) });

builder.Services.AddScoped<DialogService>();
builder.Services.AddMatBlazor();
builder.Services.AddBlazoredModal();

await builder.Build().RunAsync();
