using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace evobags.Controllers
{
    public class LearnController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EvolutionBags()
        {
            return View();
        }

        public IActionResult NaturTec()
        {
            return View();
        }

        public IActionResult Certifications()
        {
            return View();
        }
    }
}