using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrippleSLogistics.Models;

namespace TrippleSLogistics.Controllers
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

        public IActionResult BusinessHub()
        {
            return View();
        }

        public IActionResult Logistics()
        {
            return View();
        }

        public IActionResult Electronics()
        {
            return View();
        } public IActionResult Privacy()
        {
            return View();
        } public IActionResult Terms()
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