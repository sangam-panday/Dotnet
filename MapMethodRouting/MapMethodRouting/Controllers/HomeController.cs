using Microsoft.AspNetCore.Mvc;

namespace MapMethodRouting.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
