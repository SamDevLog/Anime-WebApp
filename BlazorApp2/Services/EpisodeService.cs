using BlazorApp2.Models;
using Microsoft.AspNetCore.Components;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Text.Json.Serialization;
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

        public async Task<IEnumerable<Top>> GetEpisodes()
        {
            Root root = await httpClient.GetJsonAsync<Root>("top/anime/1/upcoming");
            List<Top> top = root.top.Take(10).ToList();
            return top;
        }

        public async Task<IEnumerable<Top>> GetSeasonAnime()
        {
            Root root = await httpClient.GetJsonAsync<Root>("season/later");
            List<Top> top = root.top.Take(10).ToList();
            return top;
        }
    }
}
