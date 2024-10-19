using Microsoft.AspNetCore.Mvc;
using ninjamanager.data.Data;
using ninjamanager.data.Models;

namespace ninjamanager.Controllers.auth;

public class AccountController : Controller
{
    private readonly ApplicationDbContext _context;

    public AccountController(ApplicationDbContext context)
    {
        _context = context;
    }

    public IActionResult Login()
    {
        return View();
    }

    [HttpGet]
    [Route("Account/Register")]
    public IActionResult Register()
    {
        return View();
    }

    [HttpPost]
    [Route("Account/Register")]
    public async Task<IActionResult> Register(string name, string email, string password)
    {
        var user = new User
        {
            Name = name,
            Email = email,
            Password = password
        };
        await _context.Users.AddAsync(user);
        await _context.SaveChangesAsync();
        return RedirectToAction("Profile");
    }

    public IActionResult Logout()
    {
        return Redirect("/");
    }

    public IActionResult Profile()
    {
        // if (User.Identity.IsAuthenticated)
        // {
            return View();
        // }
        // return Redirect ("/Account/Login");

    }
}