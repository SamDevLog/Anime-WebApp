using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public enum Days{
        Monday, Tuesday, Wednesday, Thursday, Friday, Saturday, Sunday
    }
    public class WeekAnimeBase : ComponentBase
    {
        public List<Anime> AnimeList { get; set; }

        [Parameter]
        public Days Day { get; set; } = Days.Monday;
        [Parameter]
        //public string _day { get; set; }
        [Inject]
        public IAnimeService AnimeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //_day = DateTime.Today.ToString("dddd");
            AnimeList = await AnimeService.GetWeekAnime(Day);
        }

        public async Task SetDay(Days _day){
            Day = _day;
            AnimeList = await AnimeService.GetWeekAnime(Day);
            StateHasChanged();
        }
    }
}
