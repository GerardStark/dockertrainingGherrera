using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Session6.Models;

namespace Session6.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IConfiguration configuration;
        public HomeController(ILogger<HomeController> logger, IConfiguration configuration)
        {
            _logger = logger;
            this.configuration = configuration;
        }

        public IActionResult Index()
        {
            var items = new List<string>()
            {
                "JSON",
                "DOCKER",
                "KUBERNATES",
                "PYTHON",
                "RUBY",
                "RAILS",
                "JASMIN",
                "MOCA",
                "NUNIT",
                "FLASK",
                "CSHARP"
            };

            ViewBag.TitleVar = configuration.GetSection("AppSettings").GetSection("Title").Value;
            ViewBag.DataSource = items;

            return View(items);
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
