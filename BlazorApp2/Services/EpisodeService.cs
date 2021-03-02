using BlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly HttpClient httpClient;

        public EpisodeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }
        public async Task<Episode> GetEpisode(int id)
        {
            return await httpClient.GetFromJsonAsync<Episode>($"anime/{id}");
        }

        //public async Task<IEnumerable<Episode>> GetEpisodes()
        //{
        //    return await httpClient.GetFromJsonAsync < Episode[]>("top/anime/1/upcoming");
        //    //var content = await response.Content.ReadAsStringAsync();
        //    //var episodes = JsonSerializer.Deserialize<List<Episode>>(content, new JsonSerializerOptions { PropertyNameCaseInsensitive = true });
            
        //}

        public async Task<Episode[]> GetEpisodes()
        {
            return await httpClient.GetFromJsonAsync<Episode[]>("top/anime/1/upcoming");
        }
    }
}
