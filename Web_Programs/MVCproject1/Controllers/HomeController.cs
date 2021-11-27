using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MVCproject1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCproject1.Controllers
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
            StringBuilder text = new StringBuilder();
            text.Append("Hello, Just visiting");
            text.Append(" - " + DateTime.Now);
            System.IO.File.WriteAllText(@"C:\Users\PrecisionM4800\Desktop\C-sharp-Projects-TechAcademy\Logs\logMVC.txt", text.ToString());

            User user = new User();
            user.Id = 1;
            user.firstName = "Kali";
            user.lastName = "Bah";
            user.age = 33;

            return View(user);
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contacts()
        {
            List<string> names = new List<string>()
            {
                "kaly",
                "Adam",
                "Brett",
                "Mamadou"
            };
            ViewBag.Message = "Good work on creating this view";
            return View(names);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
