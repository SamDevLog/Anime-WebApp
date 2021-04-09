using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class SearchModel
    {
        public string SearchName { get; set; }
    }
    public class SearchEngineBase : ComponentBase
    {
        [Required]
        [MinLength(3, ErrorMessage = "Minimum of 3 characters required for the search!")]
        public SearchModel searchModel { get; set; }
        public HttpClient httpClient { get; set; }

        //public string searchName;

        public RootResult query;

        public async Task HandleSearch()
        {
            query = await httpClient.GetFromJsonAsync<RootResult>($"search/anime?q={searchModel.SearchName}");
        }
    }
}
