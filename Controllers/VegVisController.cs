using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using VegVisMVC.Models;

namespace VegVisMVC.Controllers
{
    public class VegVisController : Controller
    {

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult London()
        {
            return View();
        }

        public IActionResult SouthSouthEast()
        {
            return View();
        }

        public IActionResult Heart()
        {
            return View();
        }

        public IActionResult Wales()
        {
            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
