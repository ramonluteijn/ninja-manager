using Microsoft.AspNetCore.Mvc;
using ninjamanager.Models;
using System.Collections.Generic;

namespace ninjamanager.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            var items = new List<ShopItem>
            {
                new ShopItem { Id = 1, Name = "prod1", Price = 12 },
                new ShopItem { Id = 2, Name = "prod2", Price = 15 },
                new ShopItem { Id = 3, Name = "prod3", Price = 20 }
            };
            return View(items);
        }
    }
}