using AdminProjectYT.Models;
using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Mvc;

namespace AdminProjectYT.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ProductController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult AddProduct()
        {
            return View();
        }

       

        [HttpPost]
        public IActionResult AddProduct(Products product)
        {
            if (ModelState.IsValid)
            {
                _context.Products.Add(product);
                _context.SaveChanges();

                return RedirectToAction("Dashboard", "Home");
            }

            return View(product);
        }


        public IActionResult DeleteProduct(int productid)
        {
            var product = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            _context.Products.Remove(product);
            _context.SaveChanges();
            return RedirectToAction("Dashboard", "Home");
        }


        

        public IActionResult EditProduct(int productid)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            return View(data);
        }


        [HttpPost]
        public IActionResult EditProduct(string name, string description, decimal price, string color, int productid)
        {
            var data = _context.Products.FirstOrDefault(p => p.ProductId == productid);
            data.Name = name;
            data.Description = description;
            data.Price = price;
            data.Color = color;

            _context.Products.Update(data);
            _context.SaveChanges();

            return RedirectToAction("Dashboard", "Home");


        }
    }
}