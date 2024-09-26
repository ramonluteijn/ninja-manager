using Microsoft.AspNetCore.Mvc;
using ninjamanager.Models;
using System.Collections.Generic;

namespace ninjamanager.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            var categories = new List<Category>
            {
                new Category { Id = 1, Name = "cat1" },
                new Category { Id = 2, Name = "cat2" },
                new Category { Id = 3, Name = "cat3" }
            };

            var items = new List<ShopItem>
            {
                new ShopItem { Id = 1, Name = "prod1", Price = 12 },
                new ShopItem { Id = 2, Name = "prod2", Price = 15 },
                new ShopItem { Id = 3, Name = "prod3", Price = 20 }
            };
            ViewBag.Items = items;
            ViewBag.Categories = categories;
            return View();
        }
    }
}