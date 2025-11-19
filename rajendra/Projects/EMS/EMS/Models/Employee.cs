using System.ComponentModel.DataAnnotations;

namespace EmployeeMvc.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; }

        [StringLength(250)]
        public string Address { get; set; }

        [Phone, StringLength(20)]
        public string Phone { get; set; }

        [EmailAddress, StringLength(100)]
        public string Email { get; set; }

        [StringLength(100)]
        public string Department { get; set; }
    }
}
