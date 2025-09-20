using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TvcDay03View.Models;

namespace TvcDay03View.Controllers
{
    public class TvcHomeController : Controller
    {
        private readonly ILogger<TvcHomeController> _logger;

        public TvcHomeController(ILogger<TvcHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TvcIndex()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult TvcAbout()
        {
            return View();
        }

        public IActionResult TvcViewIf()
        {
            return View();
        }
        public IActionResult TvcViewLoop()
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
