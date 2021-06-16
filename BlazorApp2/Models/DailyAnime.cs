using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class DailyAnime : Anime
    {
        public DateTime? airing_start { get; set; }
        public ICollection<MALSubItem> genres { get; set; }
        public string source { get; set; }
        public ICollection<MALSubItem> producers { get; set; }
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
