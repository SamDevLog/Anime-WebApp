using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using Newtonsoft.Json.Linq;
using RestClient.Net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class UpcomingSeasonBase : ComponentBase
    {
        public List<Anime> AnimeList { get; set; }

        [Parameter]
        public Seasons Season { get; set; } = Seasons.fall;
        [Parameter]
        public int Year { get; set; }
        public IEnumerable<int> Years { get; set; } = Enumerable.Range(DateTime.Now.Year, 3);
        public string NoContentParams { get; set; } = string.Empty;
        [Inject]
        public IAnimeService AnimeService { get; set; }
        

        protected override async Task OnInitializedAsync()
        {
            Year = DateTime.Now.Year;
            AnimeList = await AnimeService.GetSeasonAnime(Year, Season);
            NoContentParams = $"{Season.ToString()} - {Year}";
        }
        

        public async Task SetSeason(Seasons season)
        {
            Season = season;
            AnimeList = await AnimeService.GetSeasonAnime(Year, Season);
            NoContentParams = $"{Season.ToString()} - {Year}";
        }

        public async Task SetYear(int year)
        {
            Year = year;
            AnimeList = await AnimeService.GetSeasonAnime(Year, Season);
            NoContentParams = $"{Season.ToString()} - {Year}";
        }
        
    }
}
