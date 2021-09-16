using System.Collections.Generic;

namespace BlazorApp2.Models
{
    public class AniApiAnimeData {
        public int current_page { get; set; }
        public int count { get; set; }
        public int last_page { get; set; }
        public List<AniApiAnimeModel> documents { get; set; }
    }
}