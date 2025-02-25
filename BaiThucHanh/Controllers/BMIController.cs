using Microsoft.AspNetCore.Mvc;
using BaiThucHanh.Models;

namespace BaiThucHanh.Controllers
{
    public class BMIController : Controller
    {
        // GET: BMI
        public ActionResult Index()
        {
            return View(new BMIModel () );
        }

        [HttpPost]
        public ActionResult Index(BMIModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateBMI();
                ViewBag.BMI = model.BMI;
                ViewBag.Result = model.BMIResult;
            }
            return View(model);
        }
    }
}

