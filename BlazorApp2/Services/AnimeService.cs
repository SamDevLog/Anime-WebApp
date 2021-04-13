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
using BlazorApp2.Pages;
using Microsoft.AspNetCore.Mvc;

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

        public async Task<SeasonRoot> GetSeasonAnime(Seasons season = Seasons.fall)
        {
            return await httpClient.GetFromJsonAsync<SeasonRoot>($"season/2021/{season}");
        }

        public async Task<RootResult> Search(string search)
        {
            return await httpClient.GetFromJsonAsync<RootResult>($"search/anime?q={search}");
        }
    }
}
