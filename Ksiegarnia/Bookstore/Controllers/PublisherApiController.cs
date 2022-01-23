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
    }
}
