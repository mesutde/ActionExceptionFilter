using Microsoft.AspNetCore.Mvc;

namespace ActionExceptionFilter.Controllers
{
    public class ErrorPageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
