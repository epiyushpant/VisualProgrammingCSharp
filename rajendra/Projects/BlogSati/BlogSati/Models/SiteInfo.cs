using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSati.Models
{
    [Table("SiteInfo")]

    public class SiteInfo
    {
        public int Id { get; set; }
        public string SiteName { get; set; } = "BlogSati";
        public string Logo { get; set; }
        public string fDescription { get; set; } = "A small river named Duden flows by their place and supplies it with the necessary regelialia.";
        public string Title { get; set; } = "Resources and insights";

        public string Description { get; set; } = "The latest industry news, interviews, technologies, and resources.";

        public string subTitle { get; set; } = "Our Blog";

        public string PrimaryColor { get; set; } = "#7C5CFA";
        public string SecondaryColor { get; set; } = "#5B4B8A";
        public string BackgroundColor { get; set; } = "#F5F3FF";
        public string TextColor { get; set; } = "#1F2937";


    }
}