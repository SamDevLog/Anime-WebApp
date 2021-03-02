using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
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
        public IEnumerable<Top> Episodes { get; set; }
        public IEnumerable<dynamic> top { get; set; }


        [Inject]
        public IEpisodeService episodeService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Episodes = await episodeService.GetEpisodes();
        }
    }
}
