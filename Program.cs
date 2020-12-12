using Microsoft.AspNetCore.Components.WebAssembly.Hosting;

using Microsoft.Extensions.DependencyInjection;

using System;

using System.Net.Http;


using System.Threading.Tasks;


namespace EADCA3
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("app");

            builder.Services.AddScoped(sp => new HttpClient { BaseAddress = new Uri(builder.HostEnvironment.BaseAddress) });
            builder.Services.AddHttpClient("LastFM Artists", client => client.BaseAddress = new Uri("https://ws.audioscrobbler.com/2.0/?method=library.getartists&api_key=6fb86347aefc0240d93a8d2a9e08f9d8&user=joanofarctan&format=json"));

            await builder.Build().RunAsync();
        }
    }
}
