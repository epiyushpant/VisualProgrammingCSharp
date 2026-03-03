using Microsoft.EntityFrameworkCore;

namespace AdminProjectYT.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options) { 
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<Products> Products { get; set; }
    }
}
