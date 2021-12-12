using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository.Interfaces;
using Microsoft.CodeAnalysis;
using PagedList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repository
{
    internal class LibraryRepository : ILibraryRepository
    {
        private BookStoreContext context;
        public const int PAGE_SIZE = 10;
        public void DeleteLibrary(int userId, int bookId)
        {
            Library libraryFromDb = context.Libraries.FirstOrDefault(x => x.user.user_id == userId && x.book.book_id == bookId);
            if (libraryFromDb != null)
                context.Libraries.Remove(libraryFromDb);

        }

        public void DeleteLibrary(int id)
        {
            Library libraryFromDb = context.Libraries.FirstOrDefault(x => x.library_id==id);
            if (libraryFromDb != null)
                context.Libraries.Remove(libraryFromDb);

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

        public Optional<Library> GetLibrary(int userId, int bookId)
        {
            Optional<Library> library = context.Libraries.FirstOrDefault(x=>x.user.user_id==userId && x.book.book_id==bookId);
            return library;
        }

        public PagedList<Library> GetLibraryByUserId(int pageNumber, int userId)
        {
            return (PagedList<Library>)context.Libraries.ToPagedList(pageNumber, PAGE_SIZE).Where(x => x.user.user_id == userId);
        }

        public void InsertLibrary(Library library)
        {
            context.Libraries.Add(library);
        }

       
    }
}
