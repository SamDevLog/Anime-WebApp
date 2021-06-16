using BlazorApp2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class AnimeListBase : BaseQueryResponse
    {
        public string season_name { get; set; }
        public int season_year { get; set; }
        public List<Anime> top { get; set; }
        public List<SeasonAnime> seasonAnimes { get; set; }
    }
}
