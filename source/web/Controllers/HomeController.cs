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
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Index.cshtml");
            return View($"Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Index.cshtml");
        }

        public IActionResult Privacy()
        {
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Privacy.cshtml");
            return View($"Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Privacy.cshtml");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            _logger.LogInformation($"Path:Views{Path.DirectorySeparatorChar}Home{Path.DirectorySeparatorChar}Privacy.cshtml");
            return View($"Path:Views{Path.DirectorySeparatorChar}Shared{Path.DirectorySeparatorChar}Error.cshtml",new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
