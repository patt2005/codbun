using Microsoft.AspNetCore.Mvc;

namespace CodBun.Controllers;

public class ContactController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}