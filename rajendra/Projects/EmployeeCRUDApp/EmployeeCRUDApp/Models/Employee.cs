using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUDApp.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        [Required]
        public string Department { get; set; }

        [Required]
        public decimal Salary { get; set; }

        [Required]
        public string Email { get; set; }
    }
}
