using DungeonEar;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

var builder = WebAssemblyHostBuilder.CreateDefault(args);
builder.RootComponents.Add<App>("#app");
builder.RootComponents.Add<HeadOutlet>("head::after");



builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

var lp = new LocationProviderFromAPI();
//var lp = new LocationProviderHardCoded();
var mge = new MainGameEngine(lp);


builder.Services.AddSingleton(typeof(MainGameEngine), mge);

await builder.Build().RunAsync();
