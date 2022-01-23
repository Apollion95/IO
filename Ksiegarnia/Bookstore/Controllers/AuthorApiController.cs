using Microsoft.AspNetCore.Mvc;
using Ksiegarnia.Mapper;
using Domain.Entities;
using System.Diagnostics;
using Infrastructure.Repository.Interfaces;

namespace Ksiegarnia.Controllers
{
    [ApiController]
    [Route("api/authors")]
    [Produces("application/json")]
    public class AuthorApiController : Controller
    {
        public IAuthorRepository authorRepository;
        public AuthorMapper authorMapper;
        public AuthorApiController(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
            
        }

        [HttpGet]
        public JsonResult GetAll()
        {
            return new JsonResult(new Author(1,"Adam", "Mickiewicz"));
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
