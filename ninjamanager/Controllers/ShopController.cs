using Microsoft.AspNetCore.Mvc;
using ninjamanager.data.Data;
using ninjamanager.data.Models;

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