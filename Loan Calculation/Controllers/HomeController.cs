using Microsoft.AspNetCore.Mvc;
using FutureValue.Models;

namespace FutureValue.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.FV = 0;
            return View();
        }

        [HttpPost]
        public IActionResult Index(FutureValueModel model)
        {
            if (ModelState.IsValid)
            {
                decimal futureValue = model.CalculateFutureValue();
                ViewBag.FV = futureValue;
            }
            else
            {
                ViewBag.Fv = 0;
            }

            return View(model);
        }
    }
}
