using System.Collections.Generic;
#nullable enable

namespace BlazorApp2.Models
{
    public class AniRoot : AniApiBase
    {
        public AniEpisode? data  { get; set; } = new();
    }
}