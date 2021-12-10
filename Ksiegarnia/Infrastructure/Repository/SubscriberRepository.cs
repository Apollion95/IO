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
    public class SubscriberRepository : ISubscriberRepository
    {
        private readonly BookStoreContext _context;

        public SubscriberRepository(BookStoreContext context)
        {
            _context = context;
        }

        public IEnumerable<Subscriber> GetSubscriber()
        {
            return _context.Subscribers;
        }
        public Subscriber GetById(int id)
        {
            return _context.Subscribers.SingleOrDefault(x=>x.sub_id == id);
        }

        public Subscriber GetByUserId(int user_id)
        {
            return _context.Subscribers.SingleOrDefault(x=>x.user.user_id == user_id);  
        }

        
        public Subscriber Add(Subscriber subscriber)
        {
            _context.Subscribers.Add(subscriber);
            _context.SaveChanges();
            return subscriber;
        }

        public void Update(Subscriber subscriber)
        {
            _context.Subscribers.Update(subscriber);
            _context.SaveChanges();

        }
       
        public void Delete(Subscriber subscriber)
        {
            _context.Remove(subscriber);
            _context.SaveChanges();
        }
    }
}
