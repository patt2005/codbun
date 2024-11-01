using Microsoft.AspNetCore.Mvc;

namespace CodBun.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}