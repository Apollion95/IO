using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface ISubscriberRepository
    {
        IEnumerable<Subscriber> GetSubscriber();
        Subscriber GetById(int id);
        Subscriber GetByUserId(int user_id);
        Subscriber Add(Subscriber subscriber);
        void Update(Subscriber subscriber);
        void Delete(Subscriber subscriber);
    }
}
