using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MockAssessment5.Models;

namespace MockAssessment5.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Calculator()
        {
            return View();
        }

        public IActionResult Result(int num1, int num2, string operation)
        {
            ViewBag.Operation = operation;

            if (operation == "Plus")
            {
                ViewBag.Result = num1 + num2;
            }

            if (operation == "Minus")
            {
                ViewBag.Result = num1 - num2;
            }

            if (operation == "Multiply")
            {
                ViewBag.Result = num1 * num2;
            }

            if (operation == "Divide")
            {
                ViewBag.Result = num1 / num2;
            }

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
