using Microsoft.AspNetCore.Mvc;

namespace SalesWeb.Controllers
{
    public class SalesRecordsContoller : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult SimpleSearch()
        {
            return View();
        }
        public IActionResult GroupingSearch()
        {
            return View();
        }
    }
}
