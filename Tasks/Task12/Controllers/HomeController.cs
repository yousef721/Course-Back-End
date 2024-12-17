using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Task12.Models;

namespace Task12.Controllers
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
            return View();
        }
        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult NotFoundPage()
        {
            return View();
        }
        public IActionResult SetName()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SetName(string name)
        {
            if (name !=  null)
            {
                CookieOptions cookieOptions = new CookieOptions();
                cookieOptions.Expires = DateTime.Now.AddDays(1);
                Response.Cookies.Append("name" , name, cookieOptions);
                return RedirectToAction("Index", "ToDoList");
            }
            return RedirectToAction("NotFoundPage");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
