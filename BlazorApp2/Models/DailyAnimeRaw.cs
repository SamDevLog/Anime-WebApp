using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class DailyAnimeRaw : BaseQueryResponse
    {
        public ICollection<DailyAnime> day { get; set; }
    }
}
