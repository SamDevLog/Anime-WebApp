using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorApp2.Pages
{
    public class AnimeDetailsBase : ComponentBase
    {
        public Anime Anime { get; set; } = new Anime();

        [Inject]
        public IAnimeService animeService { get; set; }
        [Inject]
        public IJSRuntime JS { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Anime = await animeService.GetAnime(int.Parse(Id));
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await JS.InvokeVoidAsync("initializeScroller");
            }
        }
    }
}
