using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminProjectYT.Models
{
    [Table("Products")]
    public class Products
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; } = 0.0M;
        public string Color { get; set; }
    }
}
