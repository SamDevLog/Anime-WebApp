using BlazorApp2.Models;
using BlazorApp2.Pages;
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
        public IEnumerable<Anime> Episodes { get; set; }
        public AnimeService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }


        public async Task<Anime> GetAnime(int id)
        {
            return await httpClient.GetFromJsonAsync<Anime>($"anime/{id}");
        }

        public async Task<IEnumerable<Anime>> GetAnimeList()
        {
            Root root = await httpClient.GetFromJsonAsync<Root>("top/anime/1/upcoming");
            List<Anime> top = root.top.Take(10).ToList();
            return top;
        }

        public async Task<List<Anime>> GetSeasonAnime(int year, Seasons season)
        {
            SeasonRoot seasonRoot = await httpClient.GetFromJsonAsync<SeasonRoot>($"season/{year}/{season}");
            List<Anime> seasonAnime = seasonRoot.anime.ToList();
            return seasonAnime;
        }
        public async Task<SearchResultModel> Search(string search)
        {
            return await httpClient.GetFromJsonAsync<SearchResultModel>($"search/anime?q={search}");
        }

        public async Task<List<DailyAnime>> GetWeekAnime(Days day)
        {
            DailyAnimeRaw rootWeek = await httpClient.GetFromJsonAsync<DailyAnimeRaw>($"schedule/{day}");
            List<DailyAnime> weeklyAnime = rootWeek.day;
            return weeklyAnime;
        }
    }
}
