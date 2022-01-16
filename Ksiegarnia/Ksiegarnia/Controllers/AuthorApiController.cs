﻿using Microsoft.AspNetCore.Mvc;
using Infrastructure.Repository.Interfaces;
using Ksiegarnia.Mapper;

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


        

    }
}
