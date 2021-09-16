namespace BlazorApp2.Models
{
    public class AniApiBase {
        public int? status_code { get; set; } = 200;
        public string message { get; set; } = string.Empty;
        public int? version { get; set; } = 1;
    }
}