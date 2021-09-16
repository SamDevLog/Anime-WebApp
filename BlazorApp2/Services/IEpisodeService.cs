using BlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public interface IEpisodeService{
        Task<AniEpisode> GetEpisode(int animeId, int episodeNumber);
        Task<List<AniEpisodeBase>> GetEpisodesList(int animeId);
        Task<int> GetIdOfAnime(int mal_id);
        //Task<Dictionary<string, List<AniEpisodeBase>>> GetEpisodesListsEnIt(int animeId);
        Task<List<AniEpisodeBase>> GetEnglishEpisodesList(int animeId);
        Task<List<AniEpisodeBase>> GetItalianEpisodesList(int animeId);

    }
}