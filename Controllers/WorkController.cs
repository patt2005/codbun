using Microsoft.AspNetCore.Mvc;

namespace CodBun.Controllers;

public class WorkController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}