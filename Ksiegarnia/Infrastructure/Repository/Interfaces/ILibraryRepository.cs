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
    internal interface ILibraryRepository : IDisposable
    {
        PagedList<Library> GetLibraryByUserId(int pageNumber, int userId);
        Optional<Library> GetLibrary(int userId, int bookId);
        void InsertLibrary(Library library);
        void DeleteLibrary(int userId, int bookId);
        void DeleteLibrary(int id);
    }
}
