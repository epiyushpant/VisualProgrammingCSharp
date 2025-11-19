using EmployeeMvc.Models;
using Microsoft.EntityFrameworkCore;


namespace EMS.Data
{
    public class ApplicationDbContext
    {
        public class ApplicationDbContext : DbContext
        {
            public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options) { }

            public DbSet<Employee> Employees { get; set; }
        }
    }
}
