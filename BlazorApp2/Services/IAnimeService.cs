﻿using BlazorApp2.Models;
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
        Task<IEnumerable<Top>> GetAnimeList();
        Task<SeasonRoot> GetSeasonAnime();
    }
}