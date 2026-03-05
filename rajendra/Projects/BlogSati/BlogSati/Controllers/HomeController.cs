using System.Diagnostics;
using BlogSati.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogSati.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }


        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Dashboard()
        {
            return View();
        }

        
 //Register User Controller Method


        [HttpPost]
        public IActionResult RegisterUser(string username, string email, string password, string confirmPassword)
        {
            if (password != confirmPassword)
            {
                return View("PasswordIncorrect");
            }

            var existingUser = _context.Users.FirstOrDefault(u => u.Name == username || u.Email == email);

            if (existingUser != null)
            {
                return View("existingUser");
            }

            _context.Users.Add(new Users
            {
                Name = username,
                Email = email,
                Password = password,
                
            });



            _context.SaveChanges();



            return RedirectToAction("Index");
        }

// Login Controller Method

        [HttpPost]
        public IActionResult Login(string username, string password)
        {


            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if (user == null)
            {
                return RedirectToAction("Index");
            }

            if (user.Password != password)
            {
                return RedirectToAction("PasswordIncorrect");
            }

            HttpContext.Session.SetString("Username", user.Name);

            
            return RedirectToAction("Dashboard");



        }


    }
}
