using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using System.Diagnostics;
using Infrastructure.Repository.Interfaces;
using Bookstore.Services;

namespace Bookstore.Controllers
{
    [ApiController]
    [Route("api/authors")]
    [Produces("application/json")]
    public class AuthorApiController : Controller
    {
        private AuthorService authorService;
        private AuthorMapper authorMapper;
        public AuthorApiController(AuthorService authorService, AuthorMapper authorMapper)
        {
            this.authorService = authorService;
            this.authorMapper = authorMapper;
            
        }

        [HttpGet]
        public JsonResult GetAll([FromBody]int page)
        {
            List<AuthorDto> authorDtos = new List<AuthorDto>();
            return new JsonResult(authorSer)
        }

        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {

            var author = authorRepository.GetAuthorById(id);
            if (author.HasValue)
            {
                //var authorDto = authorMapper.convertToDto(author.Value);
                return new JsonResult(author);

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
