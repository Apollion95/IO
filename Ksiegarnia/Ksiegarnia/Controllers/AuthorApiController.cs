using Microsoft.AspNetCore.Mvc;

namespace Ksiegarnia.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class AuthorApiController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
