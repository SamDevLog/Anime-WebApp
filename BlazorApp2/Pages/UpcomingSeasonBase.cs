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
        public SeasonRoot root { get; set; }

        [Parameter]
        public Seasons Season { get; set; } = Seasons.fall;
        [Parameter]
        public int Year { get; set; }
        public IEnumerable<int> Years { get; set; } = Enumerable.Range(DateTime.Now.Year, 3);

        [Inject]
        public IAnimeService animeService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Year = DateTime.Now.Year;
            root = await animeService.GetSeasonAnime(Year, Season);
        }
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            root = await animeService.GetSeasonAnime(Year, Season);
        }

        public void SetSeason(Seasons season)
        {
            Season = season;
            StateHasChanged();
        }

        public void SetYear(int year)
        {
            Year = year;
            StateHasChanged();
        }

        
    }
}
