using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repository.Interfaces;
using Ksiegarnia.Mapper;
using Domain.Entities;

namespace Ksiegarnia.Controllers
{
    [ApiController]
    [Route("api/author")]
    [Produces("application/json")]
    public class AuthorApiController : Controller
    {
        public IAuthorRepository authorRepository;
        public AuthorMapper authorMapper;
        public AuthorApiController(IAuthorRepository authorRepository, AuthorMapper authorMapper)
        {
            this.authorRepository = authorRepository;
            this.authorMapper = authorMapper;
        }

        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {

            var author = authorRepository.GetAuthorById(id);
            if (author.HasValue)
            {
                var authorDto = authorMapper.convertToDto(author.Value);
                return new JsonResult(authorDto);

            }
            return new JsonResult(null);
        }

        [HttpGet("{id}/books")]
        public JsonResult GetAuthorBooks(int id)
        {

            var author = authorRepository.GetAuthorById(id);
            if (author.HasValue)
            {
                List<Book> books = (List<Book>)author.Value.books;
                return new JsonResult(books);

            }
            return new JsonResult(null);
        }




    }
}
