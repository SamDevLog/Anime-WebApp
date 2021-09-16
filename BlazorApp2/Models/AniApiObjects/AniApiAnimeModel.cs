using System;
using System.Collections.Generic;

namespace BlazorApp2.Models
{
    public class AniApiAnimeModel {
        public int anilist_id { get; set; }
        public int? mal_id { get; set; }
        public Format format { get; set; }
        public Status status { get; set; }
        public Dictionary<string, string> titles { get; set; }
        public Dictionary<string, string> descriptions { get; set; }
        public DateTime? start_date { get; set; }
        public DateTime? end_date { get; set; }
        public Season_Period season_period { get; set; }
        public int? season_year { get; set; }
        public int episodes_count { get; set; }
        public int? episode_duration { get; set; }
        public string trailer_url { get; set; }
        public string cover_image { get; set; }
        public string cover_color { get; set; }
        public string banner_image { get; set; }
        public List<string> genres { get; set; }
        public int? sequel { get; set; }
        public int? prequel { get; set; }
        public float score { get; set; }
        public int id { get; set; }
    }
}