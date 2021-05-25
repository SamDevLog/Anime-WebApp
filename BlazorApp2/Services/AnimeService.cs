using BlazorApp2.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly HttpClient httpClient;
        public AnimeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<Anime> GetAnime(int id)
        {
            return await httpClient.GetFromJsonAsync<Anime>($"anime/{id}");
        }

        public async Task<IEnumerable<Top>> GetAnimeList()
        {
            Root root = await httpClient.GetJsonAsync<Root>("top/anime/1/upcoming");
            List<Top> top = root.top.Take(10).ToList();
            return top;
        }

        public async Task<SeasonRoot> GetSeasonAnime(int year, Seasons season)
        {
            return await httpClient.GetFromJsonAsync<SeasonRoot>($"season/{year}/{season}");
        }

        public async Task<RootResult> Search(string search)
        {
            return await httpClient.GetFromJsonAsync<RootResult>($"search/anime?q={search}");
        }
    }
}
