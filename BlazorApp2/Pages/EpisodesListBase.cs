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
        public List<string> ImgPaths { get; set; }
        public IEnumerable<Top> Episodes { get; set; }
        public IEnumerable<dynamic> top { get; set; }

        [Inject]
        public IEpisodeService episodeService { get; set; }

        public string ShortenTitle(string _title)
        {
            Title = _title.Take(30).ToString();
            return Title;
        }
        

        public void ListTopAnime()
        {
            ImgPaths = new List<string>();
            foreach (var ep in Episodes)
            {
                ImgPaths.Add(ep.image_url);
            }
        }
    }
}
