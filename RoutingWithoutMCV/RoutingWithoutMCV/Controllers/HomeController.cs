using Microsoft.AspNetCore.Mvc;

namespace RoutingWithoutMCV.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        [Route("{id?}")]
        public int Details(int? id)
        {
            return id ?? 1;
        }
    }
}
