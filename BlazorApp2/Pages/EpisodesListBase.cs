using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
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
        //public IEnumerable<Episode> Episodes { get; set; } = new List<Episode>();
        public Episode[] Top { get; set; }

        [Inject]
        public IEpisodeService episodeService { get; set; }


        protected override async Task OnInitializedAsync()
        {
            Top = await episodeService.GetEpisodes();
        }

        //private void LoadEmployees()
        //{
        //    System.Threading.Thread.Sleep(2000);

        //    Episode episode1 = new Episode()
        //    {
        //        Id = 1,
        //        Title = "One Piece",
        //        Genre = "Adventure, Comedy",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/6/73245.jpg"
        //    };

        //    Episode episode2 = new Episode()
        //    {
        //        Id = 2,
        //        Title = "Dr Stone",
        //        Genre = "Adventure, Science",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/1711/110614.jpg"
        //    };

        //    Episode episode3 = new Episode()
        //    {
        //        Id = 3,
        //        Title = "Attack on Titans",
        //        Genre = "Action, Shounen",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/1000/110531.jpg"
        //    };

        //    Episode episode4 = new Episode()
        //    {
        //        Id = 4,
        //        Title = "Death Note",
        //        Genre = "Mystery, Action",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/9/9453.jpg"
        //    };

        //    Episode episode5 = new Episode()
        //    {
        //        Id = 5,
        //        Title = "Full Alchemist : Brotherhood",
        //        Genre = "Adventure, Science",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/1223/96541.jpg"
        //    };

        //    Episode episode6 = new Episode()
        //    {
        //        Id = 6,
        //        Title = "Jujutsu Kaisen",
        //        Genre = "Supernatural, Demons, Shounen",
        //        PhotoPath = "https://cdn.myanimelist.net/images/anime/1171/109222.jpg"
        //    };

        //    Episodes = new List<Episode> { episode1, episode2, episode3, episode4, episode5, episode6 };
        //}

        
    }
}
