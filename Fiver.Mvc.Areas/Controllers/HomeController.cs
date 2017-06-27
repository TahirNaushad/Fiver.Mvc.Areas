using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Fiver.Mvc.Areas.Models.Home;

namespace Fiver.Mvc.Areas.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var model = new IndexViewModel
            {
                GreetingMessage = "Hello from outside Areas"
            };
            return View(model);
        }
    }
}
