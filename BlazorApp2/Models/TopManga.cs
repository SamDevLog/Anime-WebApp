using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class TopManga : BaseQueryResponse
    {
        public List<Manga> Top { get; set; }
    }
}
