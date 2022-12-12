using Microsoft.AspNetCore.Mvc;
using Montforttt35.Models;
using System.Diagnostics;

namespace Montforttt35.Controllers
{
    public class ClubController : Controller
    {
        private readonly ILogger<ClubController> _logger;

        public ClubController(ILogger<ClubController> logger)
        {
            _logger = logger;
        }

        public IActionResult Presentation()
        {
            return View();
        }
        public IActionResult Organigramme()
        {
            return View();
        }
        public IActionResult Actualites()
        {
            return View();
        }
        public IActionResult Interview()
        {
            return View();
        }
        public IActionResult Progressions()
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
