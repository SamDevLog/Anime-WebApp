﻿using BlazorApp2.Services;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BlazorApp2.Pages
{
    public class SearchEngineBase
    {
        [Required]
        [MinLength(3, ErrorMessage = "Minimum of 3 characters required for the search!")]
        public string SearchName { get; set; }
    }
}
