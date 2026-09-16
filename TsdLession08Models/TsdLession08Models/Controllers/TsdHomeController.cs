using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TsdLession08Models.Models;

namespace TsdLession08Models.Controllers
{
    public class TsdHomeController : Controller
    {
        private readonly ILogger<TsdHomeController> _logger;

        public TsdHomeController(ILogger<TsdHomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult TsdIndex()
        {
            return View();
        }

        public IActionResult TsdPrivacy()
        {
            return View();
        }
        public IActionResult TsdAbout()
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
