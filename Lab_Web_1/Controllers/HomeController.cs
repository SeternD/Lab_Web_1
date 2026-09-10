using System.Diagnostics;
using Lab_Web_1.Models;
using Microsoft.AspNetCore.Mvc;

namespace Lab_Web_1.Controllers
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
            ViewBag.StudentName = "Kyryluk Valentin";
            ViewBag.StudentGroup = "IPZ-24-1";
            ViewBag.University = "Khmelnytskyi National University";
            ViewBag.CourseProjectTopic = "Software development for a jewelry repair shop";

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
