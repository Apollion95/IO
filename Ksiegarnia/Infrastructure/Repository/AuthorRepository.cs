using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    public class AuthorRepository : IAuthorRepository
    {
        private BookStoreContext context;
        public const int PAGE_SIZE = 10;

        public AuthorRepository(BookStoreContext context)
        {
            this.context = context;
        }



        public void DeleteAuthor(Author author)
        {
            Author authorFromDb = context.Authors.FirstOrDefault(x => x.name.Equals(author.name) && x.lastName.Equals(author.lastName));
            if(authorFromDb!=null)
                context.Authors.Remove(authorFromDb);
            context.SaveChanges();
        }

        public void DeleteAuthor(int id)
        {
            Author authorFromDb = context.Authors.FirstOrDefault(x => x.author_Id==id);
            if (authorFromDb != null)
                context.Authors.Remove(authorFromDb);
            context.SaveChanges();
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private bool disposed = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    context.Dispose();
                }
            }
            this.disposed = true;
        }

        public Optional<Author> GetAuthorById(int id)
        {
            Optional<Author> author = context.Authors.Find(id);
            return author;
        }

        public Optional<Author> GetAuthorByNameAndLastname(string name, string lastName)
        {
            Optional<Author> author = context.Authors.FirstOrDefault(x => x.name==name && x.lastName==lastName); 
            return author;
        }

        public PagedList<Author> GetAuthors(int pageNumber)
        {
            return (PagedList<Author>)context.Authors.ToPagedList(pageNumber, PAGE_SIZE);
        }

        public PagedList<Author> GetAuthorsByLastname(int pageNumber, string lastname)
        {
            PagedList<Author> authors = (PagedList<Author>)context.Authors.Where(x => x.lastName.Equals(lastname)).ToPagedList<Author>(pageNumber, PAGE_SIZE);
            return authors;
        }

        public PagedList<Author> GetAuthorsByName(int pageNumber, string name)
        {
            PagedList<Author> authors = (PagedList<Author>)context.Authors.Where(x => x.name.Equals(name)).ToPagedList<Author>(pageNumber, PAGE_SIZE);
            return authors;
        }

        public void InsertAuthor(Author author)
        {
            context.Authors.Add(author);
            context.SaveChanges();
        }

        public void UpdateAuthor(Author author)
        {
            context.Entry(author).State=EntityState.Modified;
            context.SaveChanges();
        }

        public List<Book> GetAuthorBooks(int id)
        {
           return  context.Authors.Find(id).books.ToList();
        }
    }
}
