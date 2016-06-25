using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace evobags.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Infographic()
        {
            ViewData["Message"] = "Some terms and data points for the interested";
            return View();
        }
        public IActionResult About()
        {

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "We Want to Hear From You!";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
