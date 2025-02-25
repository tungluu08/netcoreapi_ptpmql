using BaiThucHanh.Models;
using Microsoft.AspNetCore.Mvc;


namespace BaiThucHanh.Controllers
{
    public class InvoiceController : Controller
    {
        public ActionResult Index()
        {
            return View(new InvoiceModel());
        }

        [HttpPost]
        public ActionResult Index(InvoiceModel model)
        {
            if (ModelState.IsValid)
            {
                model.CalculateTotal();
                ViewBag.TotalPrice = model.TotalPrice;
            }
            return View(model);
        }
    }
}
