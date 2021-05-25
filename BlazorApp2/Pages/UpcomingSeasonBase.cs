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
        public Seasons Season { get; set; }
        //[Parameter]
        //public int Year { get; set; }

        [Inject]
        public IAnimeService animeService { get; set; }
        [Inject]
        public NavigationManager navigationManager { get; set; }

        //[Inject]
        //public IJSRuntime JSRuntime { get; set; }

        protected override async Task OnInitializedAsync()
        {
            root = await animeService.GetSeasonAnime(Season);
            
        }

        public void ValueChanged(Seasons season)
        {
            Season = season;
            navigationManager.NavigateTo("/seasonanime/", true);
        }
    }
}
