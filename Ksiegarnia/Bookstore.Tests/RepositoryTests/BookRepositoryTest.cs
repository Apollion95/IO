using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
using Infrastructure.Repository.Interfaces;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bookstore.Tests.RepositoryTests
{
    public  class BookRepositoryTest
    {

        [Fact]
        public async Task BookRepository_Should_Delete_Book()
        {
                //given
                var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
                .UseInMemoryDatabase(Guid.NewGuid().ToString())
                .Options;

                BookStoreContext context = new BookStoreContext(dbOptions);
                context.Authors.Add(new Author(
                  Id: 1,
                  Name: "Adam",
                  LastName: "Mickiewicz"
                  ));

                context.Publishers.Add(new Publisher(
                    Id: 1,
                    Name: "MG"
                ));
                Book book = new Book();
                book.book_id = 1;
                book.name = "Pan Tadeusz";
                book.releaseDate = new DateTime(2002, 07, 16);
                book.author = context.Authors.Find(1);
                book.publisher = context.Publishers.Find(1);

                context.Store.Add(book);
                context.SaveChanges();       
            
                BookRepository bookRepository = new BookRepository(context);
            //when
            bookRepository.DeleteBook(1);
            Book bookFromDb = context.Store.Find(1);
            //then
            Assert.Null(bookFromDb);
            

        }
      

    }
}
