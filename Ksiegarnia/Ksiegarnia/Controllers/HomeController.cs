using Microsoft.AspNetCore.Mvc;

namespace Ksiegarnia.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
