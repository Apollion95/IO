using Infrastructure.Repository;
using Ksiegarnia.Helpers;
using Microsoft.AspNetCore.Mvc;


namespace Ksiegarnia.Controllers
{
    [Route("home")]
    [ApiController]
    public class HomeController : Controller
    {
        private readonly IUserRepository _repository;
        private readonly JwtService _jwtService;

        public HomeController(IUserRepository repository, JwtService jwtService)
        {
            _repository = repository;
            _jwtService = jwtService;
        }

    }
}



