using System.Diagnostics;
using AdminProjectYT.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace AdminProjectYT.Controllers
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
            var username = HttpContext.Session.GetString("Username");

            if (username != null)
            {
                return RedirectToAction("Dashboard");
            }

            return View();
        }

        public IActionResult Register()
        {
            return View();
        }

        public IActionResult Dashboard()
        {

            var username = HttpContext.Session.GetString("Username");

            if (username == null)
            {
                return RedirectToAction("Index");
            }

            var data = _context.Products.ToList();
            return View(data);
        }


        public IActionResult PasswordIncorrect()
        {
            return View();
        }

        public IActionResult existingUser() { 
        return View();
        
        
        }

        [HttpPost]
        public IActionResult RegisterUser(string username, string email, string password, string confirmPassword)
        {
            if(password != confirmPassword)
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
                Role = "User"
            });

            

            _context.SaveChanges();



            return RedirectToAction("Index");
        }

        public IActionResult UserNotFound()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Login(string username, string password)
        {

            //var localUsername = HttpContext.Session.GetString("Username");

            //if(localUsername != null)
            //{
            //    return RedirectToAction("Dashboard");


            //}


            var user = _context.Users.FirstOrDefault(u => u.Name == username);

            if(user == null)
            {
                return RedirectToAction("Index");
            }

            if (user.Password != password) {
                return RedirectToAction("PasswordIncorrect");
             }

            HttpContext.Session.SetString("Username", user.Name);
            return RedirectToAction("Dashboard");


        }

        public IActionResult Logout()
{
    HttpContext.Session.Clear(); // Remove session
    return RedirectToAction("Index");
}


    }
}
