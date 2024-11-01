using Microsoft.AspNetCore.Mvc;

namespace CodBun.Controllers;

public class TeamController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}