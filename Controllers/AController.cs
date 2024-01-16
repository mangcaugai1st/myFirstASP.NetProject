using ASP.netMVC.Models;
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
            List<Post> data = new List<Post>
            {
                new Post() { Thumbnail = "ThinkPad-logo.webp" , Title = "Review ThinkPad E590 sau 4 năm sử dụng", Link = "ThinkPad_E590"},
                new Post() { Thumbnail = "Melaleuca-leucadendra.webp" , Title = "Đôi điều về API Melafix", Link = "API_Melafix"}
            };
            return View(data);
        }
        
        public IActionResult ThinkPad_E590()
        {
            List<string>? img = new List<string>
            {
                "Ubuntu-Logo.png", //  0
                "Fedora_Logo.png", // 1 
                "Red-Hat-logo.png", // 2
                "OpenSUSE_Logo.png", // 3
                "btw_i_use_arch.jpg", // 4
                "gentoo-linux-logo.png", //5
                "20230729_162524.png", //6
                "LenovoVantage.png", //7
                "", //8
                "", //9
            };
            return View(img);
        }
        public IActionResult API_Melafix()
        {
            List<string>? img = new List<string>
            {
                "Melaleuca_leucadendra_-_Köhler–s_Medizinal-Pflanzen-092.jpg",
                "Camellia.jpg" 
            };
            return View(img);
        }
    }
}
