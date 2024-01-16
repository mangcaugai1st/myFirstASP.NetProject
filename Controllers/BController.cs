using Microsoft.AspNetCore.Mvc;

namespace ASP.netMVC.Controllers
{
    public class BController : Controller
    {
        public IActionResult Index()
        {
            return View("Index");
        }
    }
}
