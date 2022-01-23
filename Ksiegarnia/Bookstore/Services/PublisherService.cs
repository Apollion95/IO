using Domain.Entities;
using Infrastructure.Repository;

namespace Bookstore.Services
{
    public class PublisherService
    {
        PublisherRepository publisherRepository;

        public PublisherService(PublisherRepository publisherRepository)
        {
            this.publisherRepository = publisherRepository;
        }

        internal List<Publisher> getPublishers(int page)
        {
            return publisherRepository.getPublisher(page);
        }
    }
}
