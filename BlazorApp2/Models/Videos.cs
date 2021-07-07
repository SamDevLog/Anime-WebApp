using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Models
{
    public class Videos : BaseQueryResponse
    {
        public ICollection<Promo> promo { get; set; }
        public ICollection<Episode> episodes { get; set; }
    }
}
