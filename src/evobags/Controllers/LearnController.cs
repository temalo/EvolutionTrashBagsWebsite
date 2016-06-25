using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using evobags.Models.LearnViewModels;

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
        public IActionResult ImpactCalculator()
        {
            return View();
        }

        public IActionResult CalculatorResults(int NumCases)
        {
            ViewData["NumCases"] = NumCases;
            ViewData["GHGEvoBags"] = NumCases * 110 / 10000;
            ViewData["GHGStandard"] = NumCases * 176 / 10000;
            ViewData["GHGReduction"] = (NumCases * 176 / 10000) - (NumCases * 110 / 10000);
            ViewData["CarsRemoved"] = ((NumCases * 176 / 10000) - (NumCases * 110 / 10000)) * .211;
            ViewData["Trees"] = ((NumCases * 176 / 10000) - (NumCases * 110 / 10000)) * 25.64;
            ViewData["HomesPowered"] = ((NumCases * 176 / 10000) - (NumCases * 110 / 10000)) * .091;
            return View();
        }
    }
}