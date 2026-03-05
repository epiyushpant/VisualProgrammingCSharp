using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlogSati.Models
{

    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; } = "user";
    }
}
