using BlogSati.Models; // Import your Models folder (for ApplicationDbContext)
using Microsoft.EntityFrameworkCore; // Required for using Entity Framework Core

namespace BlogSati // Your project namespace
{
    public class Program
    {
        public static void Main(string[] args) // Application starting point
        {
            // Create a WebApplication builder object
            var builder = WebApplication.CreateBuilder(args);

            // Add MVC services (Controllers + Views support)
            builder.Services.AddControllersWithViews();

            // Register ApplicationDbContext with Dependency Injection container
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
            {
                // Configure SQL Server connection using connection string from appsettings.json
                options.UseSqlServer(
                    builder.Configuration.GetConnectionString("DefaultConnection")
                );
            });

            builder.Services.AddSession();
            var app = builder.Build();


            app.UseSession();
            // Build the application
            // If app is NOT in development mode (Production mode)
            if (!app.Environment.IsDevelopment())
            {
                // Use custom error handling page
                app.UseExceptionHandler("/Home/Error");

                // Enable HTTP Strict Transport Security (security feature)
                app.UseHsts();
            }

            // Redirect HTTP requests to HTTPS automatically
            app.UseHttpsRedirection();

            // Enable routing (important for MVC)
            app.UseRouting();

            // Enable Authorization middleware
            app.UseAuthorization();

            // Map static files (CSS, JS, images)
            app.MapStaticAssets();

            // Configure default route
            app.MapControllerRoute(
                name: "default", // Route name
                pattern: "{controller=Home}/{action=Index}/{id?}"
            // Default: HomeController → Index() if no URL specified
            )
            .WithStaticAssets(); // Enables static assets with route

            // Run the application
            app.Run();
        }
    }
}