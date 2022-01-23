using Bookstore.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace Bookstore.Controllers
{
    public class PublisherApiController : Controller
    {

        private PublisherService publisherService;
        public PublisherApiController(PublisherService publisherService)
        { 
            this.publisherService = publisherService;
        }

        [HttpGet]
        public JsonResult GetByPage(int page)
        {
           
            if (page < 1)
                page = 1;
            List<Publisher> authors = publisherService.getPublishers(page);
           

            return new JsonResult(authors);
        }

        [HttpGet("{id}")]
        public JsonResult GetById(int id)
        {
            return new JsonResult(publisherService.getPublisherById(id));
        }

        [HttpPost]
        public IActionResult Create([FromBody()]String name)
        {
            if (name == null || name.Length < 2)
                return BadRequest();
            Publisher publisher = publisherService.createPublisher(name);
            if (publisher == null)
                return StatusCode(409);
            return Ok(publisher);
        }

        [HttpDelete]
        public IActionResult Delete([FromBody()] Publisher publisher)
        {
            if (publisher == null)
                return BadRequest();
            publisherService.delete(publisher);

            return Delete(publisher);
        }
    }
}
