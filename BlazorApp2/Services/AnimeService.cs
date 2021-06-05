﻿using BlazorApp2.Models;
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
        public async Task<ResultRoot> Search(string search)
        {
            return await httpClient.GetFromJsonAsync<ResultRoot>($"search/anime?q={search}");
        }

        public async Task<List<Anime>> GetWeekAnime(Days day)
        {
            ResultRoot rootWeek = await httpClient.GetFromJsonAsync<ResultRoot>($"schedule/{day}");
            List<Anime> weekAnime = rootWeek.results.ToList();
            return weekAnime;
        }
    }
}
