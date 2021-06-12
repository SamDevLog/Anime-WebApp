using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class WeeklyResponseRaw : BaseQueryResponse
    {
        public ICollection<DailyAnime> monday { get; set; }
        public ICollection<DailyAnime> tuesday { get; set; }
        public ICollection<DailyAnime> wednesday { get; set; }
        public ICollection<DailyAnime> thursday { get; set; }
        public ICollection<DailyAnime> friday { get; set; }
        public ICollection<DailyAnime> saturday { get; set; }
        public ICollection<DailyAnime> sunday { get; set; }
        public ICollection<DailyAnime> other { get; set; }
        public ICollection<DailyAnime> unknown { get; set; }

    }
}
