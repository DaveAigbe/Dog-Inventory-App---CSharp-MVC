using FirstMVCApp.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FirstMVCApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger; // makes the logs that will be produced read_only

        public HomeController(ILogger<HomeController> logger) // logs information
        {
            _logger = logger;
        }

        public IActionResult Index() // sends to home page that is located in View()
        {
            return View();
        }

        public IActionResult Privacy() // sends to privacy page that is located in View()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error() // takes care of what happens when error occurs
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}