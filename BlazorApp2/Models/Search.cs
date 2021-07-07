using System.ComponentModel.DataAnnotations;

namespace BlazorApp2.Pages
{
    public class Search
    {
        [Required]
        [MinLength(3, ErrorMessage ="The name cannot be less than 3 characters long")]
        public string SearchField { get; set; }
    }
}
