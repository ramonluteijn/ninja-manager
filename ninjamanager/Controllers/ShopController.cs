using Microsoft.AspNetCore.Mvc;
using ninjamanager.Models;
using System.Collections.Generic;
using ninjamanager.Data;

namespace ninjamanager.Controllers
{
    public class ShopController : Controller
    {
        private readonly ApplicationDbContext _context;

        public ShopController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            List<Product> items = _context.Products.ToList();
            List<Category> categories = _context.Categories.ToList();
            ViewBag.Items = items;
            ViewBag.Categories = categories;
            return View();
        }
    }
}