using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class Manga
    {
        public long? mal_id { get; set; }
        public int? rank { get; set; }
        public string title { get; set; }
        public string title_english { get; set; }
        public List<string> title_synonyms { get; set; }
        public string title_japanese { get; set; }
        public Uri url { get; set; }
        public string type { get; set; }
        public string status { get; set; }
        public int? volumes { get; set; }
        public int? chapters { get; set; }
        public bool publishing { get; set; }
        public string start_date { get; set; }
        public string end_date { get; set; }
        public int? members { get; set; }
        public int? scored_by { get; set; }
        public int? popularity { get; set; }
        public float? score { get; set; }
        public int? favorites { get; set; }
        public string synopsis { get; set; }
        public string background { get; set; }
        public Uri image_url { get; set; }
    }
}
