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
        public IEnumerable<Anime> Animes { get; set; }
        public TopManga TopManga { get; set; }
        public bool jsInvoked { get; set; } = false;

        [Inject]
        public AppState AppState { get; set; }

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
            if (AppState.Animes.Count > 0)
            {
                Animes = AppState.Animes.ToList();
            }else
            {
                try
                {
                    Animes = await _episodeService.GetAnimeList();
                    AppState.AddAnimeList(Animes.ToList());
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
                
            }

            if (AppState.TopManga != null)
            {
                TopManga = AppState.TopManga;
            }else
            {
                try
                {
                    TopManga = await _episodeService.GetTopManga(); 
                    AppState.SetManga(TopManga);
                }
                catch (NotSupportedException ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

        }

        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            await _jsRuntime.InvokeVoidAsync("initializeSwiper");
        }

    }
}
