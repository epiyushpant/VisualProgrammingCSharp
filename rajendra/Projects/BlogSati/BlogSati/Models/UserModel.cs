using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

namespace BlogSati.Models
{
    public class UserModel
    {

        [Key]
        public int UserID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Role { get; set; }
    }
}
