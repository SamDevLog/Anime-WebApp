using BlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class SeasonAnime
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string image_url { get; set; }
        public string synopsis { get; set; }
        public string type { get; set; }
        public string airing_start { get; set; }
        public int? episodes { get; set; }
        public int? members { get; set; }
        public List<Genre> genres { get; set; }
        public double? score { get; set; }
        public bool continuing { get; set; }
    }
}
