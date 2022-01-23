using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class PublisherApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
