using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class AnimeDetailsBase : ComponentBase
    {
        public Dictionary<string, List<AniEpisodeBase>> EpisodesListDict { get; set; } = new Dictionary<string, List<AniEpisodeBase>>();
        public Anime Anime { get; set; } = new();
        public List<Promo> Promos { get; set; } = new();
        public List<Episode> Episodes { get; set; } = new();
        public int? AniId { get; set; }
        public Videos vids { get; set; }
        public List<AniEpisodeBase> episodesList { get; set; } = new();
        public List<AniEpisodeBase> EnglishEpisodes { get; set; } = new();
        public List<AniEpisodeBase> ItalianEpisodes { get; set; } = new();


        [Inject]
        public IAnimeService animeService { get; set; }
        [Inject]
        public IEpisodeService episodeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Anime = await animeService.GetAnime(int.Parse(Id));
            AniId = await episodeService.GetIdOfAnime(int.Parse(Id));
            if (AniId != 0)
            {
                episodesList = await episodeService.GetEpisodesList(AniId.GetValueOrDefault(1));
                EnglishEpisodes = await episodeService.GetEnglishEpisodesList(AniId.GetValueOrDefault(1));
                ItalianEpisodes = await episodeService.GetItalianEpisodesList(AniId.GetValueOrDefault(1));

                if (ItalianEpisodes != null)
                {
                    MapEpisodesListsToDict("it", ItalianEpisodes);
                }

                if (EnglishEpisodes != null)
                {
                    MapEpisodesListsToDict("en", EnglishEpisodes);
                }
            }

            Console.WriteLine(EpisodesListDict == null ? "dict is null" : EpisodesListDict.Count);
        }

        public Dictionary<string, List<AniEpisodeBase>> MapEpisodesListsToDict(string language, List<AniEpisodeBase> episodesList)
        {
            if (!EpisodesListDict.ContainsKey(language))
            {
                EpisodesListDict.Add(language, episodesList);
            }

            return EpisodesListDict;
        }
    }
}