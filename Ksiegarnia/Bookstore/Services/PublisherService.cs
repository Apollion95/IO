using Domain.Entities;
using Infrastructure.Repository;
using Microsoft.CodeAnalysis;
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
            return publisherRepository.getPublishers(page);
        }

        internal Publisher getPublisherById(int id)
        {
            Optional<Publisher> publisher = publisherRepository.getPublisherById(id);
            if (!publisher.HasValue)
                return null;
            return publisher.Value;
        }
    }
}
