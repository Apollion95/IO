﻿using Domain.Entities;
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
        Book GetBookByName (string name);
        Book GetBookById (int id);
        void InsertBook (Book book);
        void UpdateBook (Book book);
        void DeleteBook (int id);
    }
}
