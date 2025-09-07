using System.Diagnostics; 

using Microsoft.AspNetCore.Mvc; 

using MetricSystem.Models; 

 

namespace MetricSystem.Controllers; 

 

public class HomeController : Controller 

{ 

        [HttpGet] 

        public IActionResult Index() 

        { 

            ViewBag.Celsius = null; 

            return View(); 

        } 

 

        [HttpPost] 

        public IActionResult Index(FSConversionModel model) 

        { 

            if (ModelState.IsValid) 

            { 

                ViewBag.Celsius = model.ConvertToCelsius(); 

            } 

            else 

            { 

                ViewBag.Celsius = null; 

            } 

 

            return View(model); 

        } 

} 
