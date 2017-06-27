using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.Areas.Areas.Area2.Models.Home;

namespace Fiver.Mvc.Areas.Areas.Area2.Controllers
{
    [Area("Area2")]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                GreetingMessage = "Hello from Area2"
            };
            return View(model);
        }
    }
}
