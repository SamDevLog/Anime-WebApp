using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class SearchResultModel : BaseQueryResponse
    {
        public List<Anime> results { get; set; }

    }
}
