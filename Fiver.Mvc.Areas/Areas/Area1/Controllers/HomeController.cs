using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.Areas.Areas.Area1.Models.Home;

namespace Fiver.Mvc.Areas.Areas.Area1.Controllers
{
    [Area("Area1")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                GreetingMessage = "Hello from Area1"
            };
            return View(model);
        }
    }
}
