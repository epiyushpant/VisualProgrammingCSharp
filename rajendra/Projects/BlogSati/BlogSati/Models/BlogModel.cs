using System.ComponentModel.DataAnnotations;

namespace BlogSati.Models
{
    public class BlogModel
    {
        public int BlogId { get; set; }
        [Required]
        [StringLength(200)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }

        [StringLength(100)]
        public string Author { get; set; }

        [StringLength(100)]
        public string Category { get; set; }

        public string FeaturedImage { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;

        public DateTime? UpdatedAt { get; set; }

        public bool IsPublished { get; set; } = true;


    }
}
