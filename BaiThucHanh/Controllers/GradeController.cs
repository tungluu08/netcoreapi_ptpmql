using BaiThucHanh.Models;
using Microsoft.AspNetCore.Mvc;


namespace BaiThucHanh.Controllers
{
    public class GradeController : Controller
    {
        public ActionResult Index()
        {
            return View(new GradeModel());
        }

        [HttpPost]
        public ActionResult Index(GradeModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateGrade();
                ViewBag.FinalScore = model.FinalScore;
                ViewBag.Grade = model.Grade;
            }
            return View(model);
        }
    }
}
