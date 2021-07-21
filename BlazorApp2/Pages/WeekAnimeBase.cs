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
    public class WeekAnimeBase : ComponentBase
    {
        public ICollection<DailyAnime> _AnimeList = new List<DailyAnime>();
        public Dictionary<string, ICollection<DailyAnime>> WeeklyAnime { get; set; } = new Dictionary<string, ICollection<DailyAnime>>();
        public WeeklyResponseRaw apiRspn { get; set; }

        [Parameter]
        public Days Day { get; set; } = Days.Monday;
        [Inject]
        public IAnimeService AnimeService { get; set; }

        protected override async Task OnInitializedAsync()
        {
            // var _day = DateTime.Today.ToString("dddd");
            
            apiRspn = await AnimeService.GetWeekAnime();

            if (apiRspn != null)
            {
                WeeklyAnime.Add("Monday", apiRspn.monday);
                WeeklyAnime.Add("Tuesday", apiRspn.tuesday);
                WeeklyAnime.Add("Wednesday", apiRspn.wednesday);
                WeeklyAnime.Add("Thursday", apiRspn.thursday);
                WeeklyAnime.Add("Friday", apiRspn.friday);
                WeeklyAnime.Add("Saturday", apiRspn.saturday);
                WeeklyAnime.Add("Sunday", apiRspn.sunday);
                WeeklyAnime.Add("other", apiRspn.other);
                WeeklyAnime.Add("unknown", apiRspn.unknown);

                SetDay(Day);
            }

        }


        public void SetDay(Days _day)
        {
            Day = _day;
            if (!WeeklyAnime.TryGetValue(_day.ToString(), out _AnimeList)) return;
            StateHasChanged();
        }
    }
}
