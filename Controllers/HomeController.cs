using System.Text.RegularExpressions;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CalculatorWeb.Models;

namespace CalculatorWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string firstNum, string secondNum)
        {
           int numberOne = int.Parse(firstNum);
           int numberTwo = int.Parse(secondNum);
           double resultOne = Math.Sqrt(numberOne);
            double resultTwo = Math.Sqrt(numberTwo);
            ViewBag.Message1 = "Square root of " + numberOne + " = " + resultOne;
            ViewBag.Message2 = "Square root of " + numberTwo + " = " + resultTwo;

            if (resultOne > resultTwo)
            {
            ViewBag.Result1 = "Therefore " + numberOne + " has a higher Square root" ;
            }
            else if(resultTwo > resultOne)
            {
            ViewBag.Result2 = "Therefore " + numberTwo + " has a higher Square root";
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
