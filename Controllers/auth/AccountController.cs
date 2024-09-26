using Microsoft.AspNetCore.Mvc;

namespace ninjamanager.Controllers.auth;

public class AccountController : Controller
{
    public IActionResult Login()
    {
        return View();
    }

    public IActionResult Register()
    {
        return View();
    }

    public IActionResult Logout()
    {
        return Redirect("/");
    }
}