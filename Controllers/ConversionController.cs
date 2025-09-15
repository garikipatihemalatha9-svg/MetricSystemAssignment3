using Microsoft.AspNetCore.Mvc;
using MetricSystem.Models;

namespace MetricSystem.Controllers
{
    public class ConversionController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();  // 👈 Looks for Views/Conversion/Index.cshtml
        }

        [HttpPost]
        public IActionResult Index(FSConversionModel model)
        {
            if (!model.FahrenheitValue.HasValue)
            {
                ModelState.AddModelError("FahrenheitValue", "Fahrenheit Value is required.");
                return View(model);
            }

            double celsius = (model.FahrenheitValue.Value - 32) * 5 / 9;
            ViewBag.Celsius = celsius;
            return View(model);
        }
    }
}