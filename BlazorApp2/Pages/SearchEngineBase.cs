﻿using BlazorApp2.Models;
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
    public class Search
    {
        [Required]
        [MinLength(3, ErrorMessage ="The name cannot be less than 3 characters long")]
        public string SearchField { get; set; }
    }
    public class SearchEngineBase : ComponentBase
    {
        [Inject]
        public IAnimeService animeService { get; set; }
        public Search SearchField { get; set; } = new Search();
        [Parameter]
        public IEnumerable<Anime> Episodes { get; set; }

        public RootResult query;

        protected override async Task OnInitializedAsync()
        {
            Episodes = await animeService.GetAnimeList();
        }

        public async Task HandleSearch()
        {
            query = await animeService.Search(SearchField.SearchField);
        }
    }
}
