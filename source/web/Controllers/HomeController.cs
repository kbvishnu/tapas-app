using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using tapas_app.Models;

namespace tapas_app.Controllers
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
            _logger.LogInformation("Hit on hc");
            var path=Path.Combine("Views", "Home", "Index.cshtml");
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Index.cshtml");
            _logger.LogInformation($"Path2:{path}");
            return View(path);
        }

        public IActionResult Privacy()
        {
            var path = Path.Combine("Views", "Home", "Privacy.cshtml");
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Privacy.cshtml");
            _logger.LogInformation($"Path2:{path}");
            return View(path);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            var path = Path.Combine("Views", "Shared", "Error.cshtml");
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Privacy.cshtml");
            _logger.LogInformation($"Path2:{path}");
            return View(path, new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
