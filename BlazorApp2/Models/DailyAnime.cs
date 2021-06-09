using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class DailyAnime
    {
        public int mal_id { get; set; }
        public string url { get; set; }
        public string title { get; set; }
        public string image_url { get; set; }
        public string synopsis { get; set; }
        public string type { get; set; }
        public DateTime? airing_start { get; set; }
        public int? episodes { get; set; }
        public int? members { get; set; }
        public List<Genre> genres { get; set; }
        public string source { get; set; }
        public List<Producer> producers { get; set; }
        public float? score { get; set; }
        public List<object> licensors { get; set; }
        public bool r18 { get; set; }
        public bool kids { get; set; }
    }
}
