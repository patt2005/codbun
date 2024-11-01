using Microsoft.AspNetCore.Mvc;

namespace CodBun.Controllers;

public class ServicesController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}