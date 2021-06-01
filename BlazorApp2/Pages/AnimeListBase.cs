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
    public class AnimeListBase : ComponentBase
    {
        public string Title { get; set; }
        public IEnumerable<Anime> Episodes { get; set; }

        public bool jsInvoked { get; set; } = false;

        [Inject]
        public IAnimeService _episodeService { get; set; }

        [Inject]
        public IJSRuntime _jsRuntime { get; set; }

        public string ShortenTitle(string _title)
        {
            Title = _title.Take(10).ToString();
            return Title;
        }

        protected override async Task OnInitializedAsync()
        {
                Episodes = await _episodeService.GetAnimeList();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (Episodes == null || jsInvoked) return;
            await _jsRuntime.InvokeVoidAsync("initializeSwiper");
            jsInvoked = true;           
        }

    }
}
