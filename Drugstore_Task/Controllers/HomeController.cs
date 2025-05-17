using System.Diagnostics;
using Drugstore_Task.Models;
using Microsoft.AspNetCore.Mvc;

namespace Drugstore_Task.Controllers
{
    public class HomeController : Controller 
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Search(string q)
        {
            ViewBag.Query = q;
            return RedirectToAction("Search", "Home");
        }
        public IActionResult Index() => View();

        public IActionResult Creators() => RedirectToAction("Creators", "Home");

        public IActionResult Privacy() => View();
        public IActionResult About() => View();// contacts/about
        
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
