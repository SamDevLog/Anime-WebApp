using BlazorApp2.Services;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorApp2
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var builder = WebAssemblyHostBuilder.CreateDefault(args);
            builder.RootComponents.Add<App>("#app");
            builder.Services.AddSingleton<AppState>();
            builder.Services.AddHttpClient<IAnimeService, AnimeService>(client =>
            {
                client.BaseAddress = new Uri("https://api.jikan.moe/v3/");
            });

            builder.Services.AddHttpClient<IEpisodeService, EpisodeService>(client =>
            {
                client.BaseAddress = new Uri("https://api.aniapi.com/v1/");
            });

            await builder.Build().RunAsync();
        }
    }
}
