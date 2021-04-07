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
    public class EpisodesListBase : ComponentBase
    {
        public string Title { get; set; }
        public IEnumerable<Top> Episodes { get; set; }

        [Inject]
        public IEpisodeService episodeService { get; set; }

        [Inject]
        public IJSRuntime JSRuntime { get; set; }

        public string ShortenTitle(string _title)
        {
            Title = _title.Take(10).ToString();
            return Title;
        }

        protected override async Task OnInitializedAsync()
        {
            Episodes = await episodeService.GetEpisodes();
        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await Task.Delay(1000);
                await JSRuntime.InvokeAsync<Object>("initializeSwiper");
            }
        }

    }
}
