using BlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class SeasonAnime : Anime
    {
        public string airing_start { get; set; }
        public List<Genre> genres { get; set; }
        public bool continuing { get; set; }
    }
}
