using Microsoft.EntityFrameworkCore;

namespace BlogSati.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { }
         public DbSet<Users> Users { get; set; }
        public DbSet<Blogs> Blogs { get; set; }
        public DbSet<SiteInfo> SiteInfo { get; set; }
    }

    }
       
    




