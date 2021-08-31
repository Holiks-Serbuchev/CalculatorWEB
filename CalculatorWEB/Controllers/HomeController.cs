using CalculatorWEB.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace CalculatorWEB.Controllers
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

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Clicked(double item1, string item2)
        {
            double equal = 0;
            try
            {
                if (item2 != "" && item2 != null)
                {
                    char charValue = item2[item2.Length - 1];
                    item2 = item2.Remove(item2.Length - 1);
                    if (charValue == '+')
                        equal = item1 + Convert.ToDouble(item2);
                    else if (charValue == '-')
                        equal = Convert.ToDouble(item2) - item1;
                    else if (charValue == '*')
                        equal = item1 * Convert.ToDouble(item2);
                    else if (charValue == '/')
                        equal = Convert.ToDouble(item2) / item1;
                }
            }
            catch (Exception){}
            return View("Index", equal);
        }
    }
}
