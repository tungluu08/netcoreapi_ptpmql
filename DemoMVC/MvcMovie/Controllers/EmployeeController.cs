 using Microsoft.AspNetCore.Mvc;
 namespace Controllers
 public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Details()
        {
            return View();
        }