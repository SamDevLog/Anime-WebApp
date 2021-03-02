using BlazorApp2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Services
{
    public interface IEpisodeService
    {
        Task<Episode> GetEpisode(int id);
        Task<IEnumerable<Top>> GetEpisodes();
    }
}
