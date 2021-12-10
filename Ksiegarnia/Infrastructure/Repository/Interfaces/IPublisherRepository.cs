using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public interface IPublisherRepository
    {
        IEnumerable<Publisher> GetPublisher();
        Publisher GetByName(string name);
        Publisher GetById(int id);
        Publisher Add(Publisher publisher);
        void Update(Publisher publisher);
        void Delete(Publisher publisher);
    }
}
