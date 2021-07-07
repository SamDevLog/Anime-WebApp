using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorApp2.Pages
{
    public class AnimeDetailsBase : ComponentBase
    {
        [Inject]
        public IJSRuntime jsRuntime { get; set; }
        public Anime Anime { get; set; } = new();
        public List<Promo> Promos { get; set; } = new();
        public List<Episode> Episodes { get; set; } = new();
        [Inject]
        public IAnimeService animeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Anime = await animeService.GetAnime(int.Parse(Id));
            var vids = await animeService.GetAnimeVideos(int.Parse(Id));
            if (vids != null)
            {
                Promos = vids.promo.ToList();
                Episodes = vids.episodes.ToList();
            }
        }
    }
}