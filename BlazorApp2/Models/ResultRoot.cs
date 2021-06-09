using System;
using System.Collections.Generic;

namespace BlazorApp2.Models{
    public class ResultRoot
        {
            public string request_hash { get; set; }
            public bool request_cached { get; set; }
            public int? request_cache_expiry { get; set; }
            public List<DailyAnime> monday { get; set; }
            public List<DailyAnime> tuesday { get; set; }
            public List<DailyAnime> wednesday { get; set; }
            public List<DailyAnime> thursday { get; set; }
            public List<DailyAnime> friday { get; set; }
            public List<DailyAnime> saturday { get; set; }
            public List<DailyAnime> sunday { get; set; }
            public List<DailyAnime> other { get; set; }
            public List<DailyAnime> unknown { get; set; }

    }
}