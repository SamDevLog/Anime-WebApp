using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class MALSubItem
    {
        public long mal_id { get; set; }
        public string type { get; set; }
        public string url { get; set; }
        public string name { get; set; }
        public override string ToString()
        {
            return name ?? base.ToString();
        }

    }
}