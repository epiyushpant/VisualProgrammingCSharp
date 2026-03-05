using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSati.Models
{
    [Table("Blogs")]

    public class Blogs
    {
        [Key]
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
