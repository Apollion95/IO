using Domain.Entities;
using Infrastructure.Data;
using Microsoft.CodeAnalysis;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    internal class BookRepository : IBookRepository
    {
        private BookStoreContext context;
        public const int PAGE_SIZE = 10;
        public BookRepository(BookStoreContext context)
        {
            this.context = context;
        }
        public void DeleteBook(int bookId)
        {
            Book book = context.Store.Find(bookId);
            if (book != null)
                context.Store.Remove(book);
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
        public Optional<Book> GetBookById(int bookId)
        {
            Optional<Book> book = context.Store.Find(bookId);
            return book;
        }

        public Optional<Book> GetBookByName(string name)
        {
            Optional<Book> book = context.Store.FirstOrDefault(x => x.name.Equals(name));
            return book;
        }

        public PagedList<Book> GetBooks(int pageNumber)
        {
            return (PagedList<Book>)context.Store.ToPagedList(pageNumber, PAGE_SIZE);
        }

        public void InsertBook(Book book)
        {
            throw new NotImplementedException();
        }

        public void UpdateBook(Book book)
        {
            throw new NotImplementedException();
        }

      
    }
}
