using System.Collections.Generic;
using BlazorApp2.Models;

namespace BlazorApp2
{
    public class AppState
    {
        private readonly List<Anime> _animes = new();
        public IReadOnlyList<Anime> Animes => _animes.AsReadOnly();

        public TopManga TopManga {get; private set;}
        public WeeklyResponseRaw WeeklyResponseRaw {get; private set;}


        public void AddAnimeList(List<Anime> animes){
            _animes.AddRange(animes);
        }

        public void SetManga(TopManga topManga){
            TopManga = topManga;
        }

        public void SetWeeklyAnimeResponse(WeeklyResponseRaw weeklyResponseRaw){
            WeeklyResponseRaw = weeklyResponseRaw;
        }
    }
}