using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class Episode
    {
        public int mal_id { get; set; }
        public int? rank { get; set; }
        public string title { get; set; }
        public string start_date { get; set; }
        public string image_url { get; set; }
    }
}
