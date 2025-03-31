using Microsoft.AspNetCore.Mvc;

namespace ViewStart.Controllers
{
    [Route("[controller]/[action]")]
    public class HomeController : Controller
    {
        [Route("~/")]
        [Route("~/Home")]
        public IActionResult Index()
        {
            ViewBag.Data1 = "Sangam";
            ViewBag.Data2 = 25;
            ViewBag.Data3 = DateTime.Now.ToLongDateString();
            string[] arr = { "Sangam", "Panday" };
            ViewBag.Data4 = arr;
            ViewBag.Data5 = new List<string>()
            {
                "Cricket", "Football", "Tennis"
            };
            ViewData["MyName"] = "Sangam";
            ViewBag.data6 = "Hello, World!";

            //ViewData["data1"] = "Sangam";
            //ViewData["data2"] = 25;
            //ViewData["data3"] = DateTime.Now.ToLongDateString();
            //string[] arr = { "Sangam", "Panday" };
            //ViewData["data4"] = arr;
            //ViewData["data5"] = new List<string>()
            //{
            //    "Cricket", "Football", "Tennis"
            //};
            return View();
        }
        public IActionResult About()
        {
            return View();
        }
        public IActionResult Contact()
        {
            return View();
        }
    }
}
