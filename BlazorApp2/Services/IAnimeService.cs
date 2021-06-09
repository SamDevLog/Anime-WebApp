using BlazorApp2.Models;
using BlazorApp2.Pages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public interface IAnimeService
    {
        Task<Anime> GetAnime(int id);
        Task<IEnumerable<Anime>> GetAnimeList();
        Task<List<Anime>> GetSeasonAnime(int Year, Seasons season = Seasons.fall);
        Task<SearchResultModel> Search(string search);
        Task<List<DailyAnime>> GetWeekAnime(Days day);
    }
}
