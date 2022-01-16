using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repository.Interfaces;
namespace Ksiegarnia.Controllers
{
    [ApiController]
    [Route("author")]
    [Produces("application/json")]
    public class AuthorApiController : Controller
    {
        public IAuthorRepository authorRepository;
       public AuthorApiController(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {
            var author = authorRepository.GetAuthorById(id);
            if (author.HasValue)
                return new JsonResult(author);
            return new JsonResult(null);
        }

        [HttpGet("{}")]
        

    }
}
