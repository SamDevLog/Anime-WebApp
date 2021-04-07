using BlazorApp2.Models;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class UpcomingSeasonBase : ComponentBase
    {
        public IEnumerable<Top> Episodes { get; set; }


    }
}
