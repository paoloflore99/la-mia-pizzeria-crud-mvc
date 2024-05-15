using Microsoft.AspNetCore.Mvc;

namespace Sneke.Controllers
{
    public class HomeController1 : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
