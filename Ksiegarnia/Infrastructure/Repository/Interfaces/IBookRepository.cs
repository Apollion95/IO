using Domain.Entities;
using Microsoft.CodeAnalysis;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    internal interface IBookRepository : IDisposable
    {
        PagedList<Book> GetBooks(int pageNumber);
        PagedList<Book> GetBooksByPhrase(int pageNumber, string phrase);
        PagedList<Book> GetBooksByPublisher(int pageNumber, string publisher);
        Optional<Book> GetBookByName (string name);
        Optional<Book> GetBookById (int id);
        void InsertBook (Book book);
        void UpdateBook (Book book);
        void DeleteBook (int id);
    }
}
