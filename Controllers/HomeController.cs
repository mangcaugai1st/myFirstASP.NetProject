using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ASP.netMVC.Models;

namespace ASP.netMVC.Controllers;

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

    public IActionResult A()
    {
        return View();
    }
    [HttpPost]
    public IActionResult A(double nDegrees, string temperatureUnit)
    {
        double a = nDegrees;
        string b = temperatureUnit;
        double result;
        string resultWithUnitSymbol;
        switch (b)
        {
            case "Fahrenheit":
                result = (5*a - 160)/9;
                resultWithUnitSymbol = string.Concat(Math.Round(result, 2), "°C");
                ViewBag.ResultWithUnitSymbol = resultWithUnitSymbol;
                break; 
            case "Celsius":
                result = (9 * a / 5) + 32;
                resultWithUnitSymbol = string.Concat(Math.Round(result, 2), "°F");
                ViewBag.ResultWithUnitSymbol = resultWithUnitSymbol;
                break;
        }
        return View();
    }
    public IActionResult B()
    {
        return View();
    }
    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
