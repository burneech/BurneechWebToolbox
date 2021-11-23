using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.DependencyInjection;
using BurneechWebToolbox.Services;
using System.Threading.Tasks;
using System.Net.Http;
using System;

namespace BurneechWebToolbox
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });

            builder.Services.AddTransient<IDataService, JSONDataService>();

            await builder.Build().RunAsync();
        }
    }
}