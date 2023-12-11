using Microsoft.AspNetCore.Mvc;
using RedirectResultActionsCoreMvc.Models;
using System.Diagnostics;

namespace RedirectResultActionsCoreMvc.Controllers
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

        public RedirectResult MyProfile()
        {
            return Redirect("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }
        public RedirectResult Profile()
        {
            return RedirectPermanent("https://www.c-sharpcorner.com/members/farhan-ahmed24");
        }

        public RedirectToActionResult EmployeeList()
        {
            return RedirectToAction("Index", "Employees");
        }

        public RedirectToRouteResult DepartmentList()
        {
            return RedirectToRoute(new { action = "Index", controller = "Departments", area = "" });
        }

        public LocalRedirectResult LocalRedirect()
        {
            return LocalRedirect("/Home/Index");
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