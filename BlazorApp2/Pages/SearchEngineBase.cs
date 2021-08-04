using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Forms;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class SearchEngineBase : ComponentBase
    {
        [Inject]
        public IAnimeService animeService { get; set; }
        [Parameter]
        public string passedQuery { get; set; }
        public Search SearchField { get; set; } = new();
        public int AnimeCount {get; set;}
        [Inject]
        public IJSRuntime JSRuntime { get; set; }
        public SearchResultModel query;
        public Types Type { get; set; } = Types.anime;

        protected override async Task OnParametersSetAsync()
        {
            if (!String.IsNullOrEmpty(passedQuery))
            {
                SearchField.SearchField = passedQuery;
                query = await animeService.Search(passedQuery, Type);
                SearchField.SearchField = "";  
            }
        }

        public async Task HandleSearch()
        {
            query = await animeService.Search(SearchField.SearchField, Type);
            SearchField.SearchField = "";
        }

        public void SetType(Types _type)
        {
            Type = _type;
        }

        public void OpenLink(Uri url)
        {
            Console.WriteLine(url);
        }
    }
}
