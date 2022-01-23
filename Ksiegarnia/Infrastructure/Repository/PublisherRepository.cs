using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class PublisherRepository : IPublisherRepository
    {

        private BookStoreContext _context;

        public PublisherRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Publisher> GetPublisher()
        {
            return _context.Publishers;
        }

       

        public Publisher GetById(int id)
        {
            return _context.Publishers.SingleOrDefault(x => x.publisher_id == id);
        }

        public Publisher GetByName(string name)
        {
            return _context.Publishers.SingleOrDefault(x => x.name == name);
        }

        public Publisher Add(Publisher publisher)
        {
            
            _context.Publishers.Add(publisher);
            _context.SaveChanges();
            return publisher;
        }

      

        public void Update(Publisher publisher)
        {
            _context.Publishers.Update(publisher);
            _context.SaveChanges();
        }

        public void Delete(Publisher publisher)
        {
            _context.Publishers.Remove(publisher);
            _context.SaveChanges();
            
        }
    }
}
