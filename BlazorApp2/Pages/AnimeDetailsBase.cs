using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class AnimeDetailsBase : ComponentBase
    {
        public Anime Anime { get; set; } = new();
        public List<Promo> Promos { get; set; } = new();
        public List<Episode> Episodes { get; set; } = new();
        public Videos vids { get; set; }
        [Inject]
        public IAnimeService animeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Anime = await animeService.GetAnime(int.Parse(Id));
            vids = await animeService.GetAnimeVideos(int.Parse(Id));
            if (vids != null)
            {
                Promos = vids.promo.ToList();
                Episodes = vids.episodes.ToList();
            }
        }
    }
}