using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.Areas.Areas.Area2.Controllers
{
    [Area("Area2")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
