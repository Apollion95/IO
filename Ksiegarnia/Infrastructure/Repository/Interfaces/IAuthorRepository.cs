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
    public interface IAuthorRepository : IDisposable
    {
        PagedList<Author> GetAuthors(int pageNumber);
        PagedList<Author> GetAuthorsByName(int pageNumber, string name);
        PagedList<Author> GetAuthorsByLastname(int pageNumber, string lastname);
        Optional<Author> GetAuthorById(int id);
        Optional<Author> GetAuthorByNameAndLastname(string name, string lastname);
        void InsertAuthor(Author author);
        void UpdateAuthor(Author author);
        void DeleteAuthor(Author author);
        void DeleteAuthor(int id);
        List<Book> GetAuthorBooks(int id);
    }
}
