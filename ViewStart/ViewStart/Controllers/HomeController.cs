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
            ViewData["data1"] = "View Data";
            ViewBag.data2 = "View Bag";
            TempData["data3"] = "Temp Data";
            TempData.Keep();
            TempData["data4"] = new List<string>()
            {
                "Football", "Cricket", "Tennis"
            };
            return View();
        }
        public IActionResult About()
        {
            TempData.Keep("data3");
            return View();
        }
        public IActionResult Contact()
        {
            TempData.Keep("data3");
            return View();
        }
    }
}


//ViewBag.Data1 = "Sangam";
//ViewBag.Data2 = 25;
//ViewBag.Data3 = DateTime.Now.ToLongDateString();
//string[] arr = { "Sangam", "Panday" };
//ViewBag.Data4 = arr;
//ViewBag.Data5 = new List<string>()
//{
//    "Cricket", "Football", "Tennis"
//};
//ViewData["MyName"] = "Sangam";
//ViewBag.data6 = "Hello, World!";

//ViewData["data1"] = "Sangam";
//ViewData["data2"] = 25;
//ViewData["data3"] = DateTime.Now.ToLongDateString();
//string[] arr = { "Sangam", "Panday" };
//ViewData["data4"] = arr;
//ViewData["data5"] = new List<string>()
//{
//    "Cricket", "Football", "Tennis"
//};