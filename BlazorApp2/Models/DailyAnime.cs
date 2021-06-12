using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class DailyAnime
    {
        public long mal_id { get; set; }
        public Uri url { get; set; }
        public string title { get; set; }
        public Uri image_url { get; set; }
        public string synopsis { get; set; }
        public string type { get; set; }
        public DateTime? airing_start { get; set; }
        public int? episodes { get; set; }
        public int? members { get; set; }
        public ICollection<MALSubItem> genres { get; set; }
        public string source { get; set; }
        public ICollection<MALSubItem> producers { get; set; }
        public float? score { get; set; }
        public ICollection<string> licensors { get; set; }
        public bool? r18 { get; set; }
        public bool? kids { get; set; }
        public bool? continuing { get; set; }
    }

    public class Licensor
    {
        public string licensor { get; set; }
    }
}
