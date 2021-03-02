using BlazorApp2.Models;
using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class EpisodeDetailsBase : ComponentBase
    {
        public Episode Episode { get; set; } = new Episode();

        [Inject]
        public IEpisodeService episodeService { get; set; }

        [Parameter]
        public string Id { get; set; }

        protected async override Task OnInitializedAsync()
        {
            Id = Id ?? "1";
            Episode = await episodeService.GetEpisode(int.Parse(Id));
        }
    }
}
