using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AdminProjectYT.Models
{
    [Table("Users")]
    public class Users
    {
        [Key]
        public int UserId { get; set; }
        [MaxLength(40)]
        public string Name { get; set; }
        [MaxLength(40)]
        public string Email { get; set; }
        [MaxLength(20)]

        [PasswordPropertyText]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}
