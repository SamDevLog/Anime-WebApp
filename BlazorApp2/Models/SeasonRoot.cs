using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class SeasonRoot
    {
        public string request_hash { get; set; }
        public bool request_cached { get; set; }
        public int? request_cache_expiry { get; set; }
        public string season_name { get; set; }
        public int? season_year { get; set; }
        public List<Anime> anime { get; set; }
    }
}
