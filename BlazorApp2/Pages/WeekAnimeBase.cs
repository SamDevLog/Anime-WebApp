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
        monday, tuesday, wednesday, thursday, friday, Saturday, sunday
    }
    public class WeekAnimeBase : ComponentBase
    {
        public List<DailyAnime> _AnimeList { get; set; }

        [Parameter]
        public Days Day { get; set; } = Days.monday;
        [Inject]
        public IAnimeService AnimeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            //var _day = DateTime.Today.ToString("dddd");
            _AnimeList = await AnimeService.GetWeekAnime(Day);
        }

        //public async Task SetDay(Days _day){
        //    _AnimeList = await AnimeService.GetWeekAnime();
        //    StateHasChanged();
        //}
    }
}
