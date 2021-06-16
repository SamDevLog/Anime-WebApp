using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class SeasonRoot : BaseQueryResponse
    {
        public string season_name { get; set; }
        public int? season_year { get; set; }
        public List<Anime> anime { get; set; }
    }
}
