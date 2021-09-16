using System.Collections.Generic;


namespace BlazorApp2.Models{
    public class AniEpisode
    {
        public int current_page { get; set; } = 0;
        public int count { get; set; } = 0;
        public int last_page { get; set; } = 0;
        public List<AniEpisodeBase> documents { get; set; } = new();
    }
}