using Microsoft.AspNetCore.Mvc;

namespace Fiver.Mvc.Areas.Areas.Area1.Controllers
{
    [Area("Area1")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
