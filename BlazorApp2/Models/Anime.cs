using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class Anime
    {
        public long? mal_id { get; set; }
        public int? rank { get; set; }
        public string title { get; set; }
        public Uri url { get; set; }
        public Uri image_url { get; set; }
        public string type { get; set; }
        public int? episodes { get; set; }
        public string start_date { get; set; }
        public string synopsis { get; set; }
        public string end_date { get; set; }
        public int? members { get; set; }
        public float? score { get; set; }
    }
}
