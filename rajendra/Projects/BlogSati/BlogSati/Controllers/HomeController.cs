using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;

namespace BlogSati.Controllers
{
    public class HomeController : Controller
    {
       

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
