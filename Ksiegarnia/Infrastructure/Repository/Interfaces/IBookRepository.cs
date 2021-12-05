using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    internal interface IBookRepository : IDisposable
    {
        IEnumerable<Book> GetBooks();
        Book GetBookByName (string name);
        Book GetBookById (int id);
        void InsertBook (Book book);
        void UpdateBook (Book book);
        void DeleteBook (int id);
    }
}
