using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.Areas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
