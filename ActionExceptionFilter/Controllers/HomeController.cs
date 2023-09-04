using ActionExceptionFilter.Filters;
using Microsoft.AspNetCore.Mvc;

namespace ActionExceptionFilter.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            int b = 0;
            var a = 1 / b;

            return View();
        }
    }
}
