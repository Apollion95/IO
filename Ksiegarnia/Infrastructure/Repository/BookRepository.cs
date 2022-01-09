using Domain.Entities;
using Infrastructure.Data;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository.Interfaces
{
    public class BookRepository : IBookRepository
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

        public PagedList<Book> GetBooksByPhrase(int pageNumber, string phrase)
        {
            return (PagedList<Book>)context.Store.Where(x => x.name.Contains(phrase)).ToPagedList(pageNumber, PAGE_SIZE);
        }

        public PagedList<Book> GetBooksByPublisher(int pageNumber, string publisher)
        {
            return (PagedList<Book>)context.Store.Where(x => x.publisher.name.Contains(publisher)).ToPagedList(pageNumber, PAGE_SIZE);
        }

        public void InsertBook(Book book)
        {
            context.Store.Add(book);
        }

        public void UpdateBook(Book book)
        {
            context.Entry(book).State = EntityState.Modified;
            context.SaveChanges();

        }

      
    }
}
