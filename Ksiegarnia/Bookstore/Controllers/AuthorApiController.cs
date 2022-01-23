using Microsoft.AspNetCore.Mvc;
using Domain.Entities;
using Bookstore.Services;
using Bookstore.Mapper;
using Bookstore.Dtos;


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
        public JsonResult GetByPage( int page)
        {
            List<AuthorDto> authorDtos = new List<AuthorDto>();
            if (page < 1)
                page = 1;
            List<Author> authors = authorService.getAuthors(page);
            foreach(Author author in authors)
                {
                authorDtos.Add(authorMapper.convertToDto(author));
                }

            return new JsonResult(authorDtos);
        }

        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {         
            return new JsonResult(authorService.GetAuthorById(id));
        }

        [HttpGet("{id}/books")]
        public JsonResult GetAuthorBooks(int id)
        {
            return new JsonResult(authorService.getAuthorBooks(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody()] AuthorDto authorDto)
        {
            if (authorDto == null)
                return BadRequest();

            Author author = authorMapper.convertToEntity(authorDto);
            author = authorService.CreateAuthor(author);
            if (author==null)
                return StatusCode(409);
            return Ok(authorDto);
        }


    }
}
