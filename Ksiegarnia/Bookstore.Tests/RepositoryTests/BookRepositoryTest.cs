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
        [Fact]
        public async Task BookRepository_Should_Get_Book_By_Id()
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
            Optional<Book> bookFromDb = bookRepository.GetBookById(1);
            //then
            Assert.True(bookFromDb.HasValue);
            Assert.Equal(1, bookFromDb.Value.book_id);
            Assert.Equal("Pan Tadeusz", bookFromDb.Value.name);
            Assert.Equal(new DateTime(2002, 07, 16), bookFromDb.Value.releaseDate);

            Assert.Equal(1, bookFromDb.Value.author.author_Id);
            Assert.Equal("Adam", bookFromDb.Value.author.name);
            Assert.Equal("Mickiewicz", bookFromDb.Value.author.lastName);

            Assert.Equal(1, bookFromDb.Value.publisher.publisher_id);
            Assert.Equal("MG", bookFromDb.Value.publisher.name);

        }

        [Fact]
        public async Task BookRepository_Should_Get_Book_By_Name()
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
            Optional<Book> bookFromDb = bookRepository.GetBookByName("Pan Tadeusz");
            //then
            Assert.True(bookFromDb.HasValue);
            Assert.Equal(1, bookFromDb.Value.book_id);
            Assert.Equal("Pan Tadeusz", bookFromDb.Value.name);
            Assert.Equal(new DateTime(2002, 07, 16), bookFromDb.Value.releaseDate);

            Assert.Equal(1, bookFromDb.Value.author.author_Id);
            Assert.Equal("Adam", bookFromDb.Value.author.name);
            Assert.Equal("Mickiewicz", bookFromDb.Value.author.lastName);

            Assert.Equal(1, bookFromDb.Value.publisher.publisher_id);
            Assert.Equal("MG", bookFromDb.Value.publisher.name);

        }


        [Fact]
        public async Task BookRepository_Should_Get_Books_By_PageNumber()
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

            Book book2 = new Book();
            book2.book_id = 2;
            book2.name = "Sonety Krymskie";
            book2.releaseDate = new DateTime(2006, 11, 11);
            book2.author = context.Authors.Find(1);
            book2.publisher = context.Publishers.Find(1);

            Book book3 = new Book();
            book3.book_id = 3;
            book3.name = "Reduta Ordona";
            book3.releaseDate = new DateTime(2000, 03, 12);
            book3.author = context.Authors.Find(1);
            book3.publisher = context.Publishers.Find(1);

            context.Store.Add(book);
            context.Store.Add(book2);
            context.Store.Add(book3);
            context.SaveChanges();

            BookRepository bookRepository = new BookRepository(context);
            //when
            List<Book> books = bookRepository.GetBooks(1).ToList();
            //then

            Assert.Equal(3, books.Count);
            Assert.NotNull(books.FirstOrDefault(x => x.book_id == 1));
            Assert.NotNull(books.FirstOrDefault(x => x.book_id == 2));
            Assert.NotNull(books.FirstOrDefault(x => x.book_id == 3));

        }


        [Fact]
        public async Task BookRepository_Should_Insert_Book()
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
            context.SaveChanges();

            BookRepository bookRepository = new BookRepository(context);
            Book book = new Book();
            book.book_id = 1;
            book.name = "Pan Tadeusz";
            book.releaseDate = new DateTime(2002, 07, 16);
            book.author = context.Authors.Find(1);
            book.publisher = context.Publishers.Find(1);
            //when
            bookRepository.InsertBook(book);
            Optional<Book> bookFromDb = bookRepository.GetBookById(1);

            //then
            Assert.True(bookFromDb.HasValue);
            Assert.Equal(1, bookFromDb.Value.book_id);
            Assert.Equal("Pan Tadeusz", bookFromDb.Value.name);
            Assert.Equal(new DateTime(2002, 07, 16), bookFromDb.Value.releaseDate);

            Assert.Equal(1, bookFromDb.Value.author.author_Id);
            Assert.Equal("Adam", bookFromDb.Value.author.name);
            Assert.Equal("Mickiewicz", bookFromDb.Value.author.lastName);

            Assert.Equal(1, bookFromDb.Value.publisher.publisher_id);
            Assert.Equal("MG", bookFromDb.Value.publisher.name);

        }

        [Fact]
        public async Task BookRepository_Should_Update_Book()
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
            Book bookFromDb = bookRepository.GetBookById(1).Value;
            bookFromDb.name = "Reduta Ordona";
            bookRepository.UpdateBook(bookFromDb);

            //then
            Book updatedBook = bookRepository.GetBookById(1).Value;

            Assert.Equal("Reduta Ordona", updatedBook.name);

        }


        [Fact]
        public async Task BookRepository_Should_Get_Books_By_Phrase()
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

            context.Authors.Add(new Author(
             Id: 2,
             Name: "Krystian",
             LastName: "Lipiński"
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

            Book book2 = new Book();
            book2.book_id = 2;
            book2.name = "Pan Adam";
            book2.releaseDate = new DateTime(1997, 10, 07);
            book2.author = context.Authors.Find(2);
            book2.publisher = context.Publishers.Find(1);
            context.Store.Add(book2);

            context.SaveChanges();

            BookRepository bookRepository = new BookRepository(context);


            //when
            List<Book> books = bookRepository.GetBooksByPhrase(1, "Pan").ToList();

            //then
            Assert.Equal(2, books.Count);
            Assert.NotNull(books[0]);
            Assert.NotNull(books[1]);

        }
    }
}
