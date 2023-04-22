using Microsoft.AspNetCore.Mvc;

namespace ASP.netMVC.Controllers
{
    public class AController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public AController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View("Index");
        }
        public IActionResult ThinkPad_E590()
        {
            return View("ThinkPad_E590");
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
