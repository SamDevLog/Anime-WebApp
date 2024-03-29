﻿using BlazorApp2.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Days = BlazorApp2.Models.Days;

namespace BlazorApp2.Services
{
    public class AnimeService : IAnimeService
    {
        private readonly HttpClient httpClient;
        private readonly AppState appState;

        public IEnumerable<Anime> Episodes { get; set; }
        public AnimeService(HttpClient httpClient, AppState appState)
        {
            this.httpClient = httpClient;
            this.appState = appState;
        }


        public async Task<Anime> GetAnime(int id)
        {
            return await httpClient.GetFromJsonAsync<Anime>($"anime/{id}");
        }

        public async Task<IEnumerable<Anime>> GetAnimeList()
        {
            AnimeListBase root = await httpClient.GetFromJsonAsync<AnimeListBase>("top/anime/1/upcoming");
            List<Anime> top = root.top.Take(10).ToList();
            return top;
        }

        public async Task<List<Anime>> GetSeasonAnime(int year, Seasons season)
        {
            SeasonRoot seasonRoot = await httpClient.GetFromJsonAsync<SeasonRoot>($"season/{year}/{season}");
            List<Anime> seasonAnime = seasonRoot.anime.ToList();
            return seasonAnime;
        }
        public async Task<SearchResultModel> Search(string search, Types type)
        {
            return await httpClient.GetFromJsonAsync<SearchResultModel>($"search/{type}?q={search}");
        }

        public async Task<WeeklyResponseRaw> GetWeekAnime()
        {
            return await httpClient.GetFromJsonAsync<WeeklyResponseRaw>("schedule");
        }

        public async Task<ICollection<DailyAnime>> GetDailyAnime(Days _day)
        {
            DailyAnimeRaw dailyAnime = await httpClient.GetFromJsonAsync<DailyAnimeRaw>($"schedule/{_day}");
            return dailyAnime.day;
        }

        public async Task<Videos> GetAnimeVideos(int id)
        {
            return await httpClient.GetFromJsonAsync<Videos>($"anime/{id}/videos");
        }

        public async Task<TopManga> GetTopManga()
        {
            return await httpClient.GetFromJsonAsync<TopManga>("top/manga/1/bypopularity");
        }

        public async Task<Manga> GetManga(int id)
        {
            return await httpClient.GetFromJsonAsync<Manga>($"manga/{id}");
        }
    }
}
