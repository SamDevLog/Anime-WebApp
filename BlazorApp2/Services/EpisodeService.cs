using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using BlazorApp2.Models;

namespace BlazorApp2.Services
{
    public class EpisodeService : IEpisodeService
    {
        private readonly HttpClient _httpClient;

        public EpisodeService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<List<AniEpisodeBase>> GetEnglishEpisodesList(int animeId)
        {
            List<AniEpisodeBase> enEpisodes = new();

            var responseBodyEn = await _httpClient.GetStringAsync($"episode?anime_id={animeId}&locale=en");
            
            if (responseBodyEn.Contains("404"))
            {
                return null;
            }

            var response = await _httpClient.GetFromJsonAsync<AniRoot>($"episode?anime_id={animeId}&locale=en");

            if (response.data.documents != null)
            {
                enEpisodes = response.data.documents.Where(x => !x.Source.Contains("dub")).ToList();
            }

            return enEpisodes;
        }

        public async Task<AniEpisode> GetEpisode(int animeId, int episodeNumber)
        {
            return await _httpClient.GetFromJsonAsync<AniEpisode>($"episode?anime_id={animeId}&number={episodeNumber}");
        }

        public async Task<int> GetIdOfAnime(int mal_id)
        {
            var responseBody = await _httpClient.GetStringAsync($"anime?mal_id={mal_id}");
            if (responseBody.Contains("404")) return 0;
            var response = await _httpClient.GetFromJsonAsync<AniApiAnimeResponse>($"anime?mal_id={mal_id}");
            if (response.data == null) return 0;
            return response.data.documents[0].id;
        }

        public async Task<List<AniEpisodeBase>> GetItalianEpisodesList(int animeId)
        {
            List<AniEpisodeBase> itEpisodes = new();

            var responseBodyIT = await _httpClient.GetStringAsync($"episode?anime_id={animeId}&locale=it");

            if (responseBodyIT.Contains("404"))
            {
                Console.WriteLine("IT response body returned 404");
                return null;
            }

            var response = await _httpClient.GetFromJsonAsync<AniRoot>($"episode?anime_id={animeId}&locale=it");

            if (response.data.documents != null)
            {
                itEpisodes = response.data.documents.Where(x => !string.IsNullOrEmpty(x.Title)).ToList();
            }

            return itEpisodes;
        }
    }
}