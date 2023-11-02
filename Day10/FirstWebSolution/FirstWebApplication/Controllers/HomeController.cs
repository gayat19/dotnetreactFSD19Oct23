using Microsoft.AspNetCore.Mvc;

namespace FirstWebApplication.Constrollers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Landing()
        {
            return View();
        }
        [ActionName("Foxy")]
        public IActionResult CannotBeTheNameInTheRequestCozItsReallyLong()
        {
            return View();
        }
    }
}
