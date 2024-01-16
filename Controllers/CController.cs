using Microsoft.AspNetCore.Mvc;

namespace ASP.netMVC.Controllers
{
    public class CController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(double nDegrees, string temperatureUnit)
        {
            double a = nDegrees;
            string b = temperatureUnit;
            double result;
            string resultWithUnitSymbol;
            switch (b)
            {
                case "Fahrenheit":
                    result = (5 * a - 160) / 9;
                    resultWithUnitSymbol = string.Concat(Math.Round(result, 2), "°C");
                    ViewBag.ResultWithUnitSymbol = resultWithUnitSymbol;
                    break;
                case "Celsius":
                    result = (9 * a / 5) + 32;
                    resultWithUnitSymbol = string.Concat(Math.Round(result, 2), "°F");
                    ViewBag.ResultWithUnitSymbol = resultWithUnitSymbol;
                    break;
            }
            return View("Index");
        }
    }
}
