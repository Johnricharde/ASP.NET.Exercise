using ASP.NET.Exercise.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ASP.NET.Exercise.Controllers
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

        public IActionResult Expenses()
        {
            return View();
        }

        public IActionResult CreateEditExpense()
        {
            return View();
        }

        public IActionResult CreateEditExpenseForm(Expense model)
        {
            return RedirectToAction("Expenses");
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
