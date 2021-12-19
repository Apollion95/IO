using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Moq;
using Xunit;

namespace Bookstore.Tests.RepositoryTests
{
    public class AuthorRepositoryTest
    {





        [Fact]
        public async Task AuthorRepository_Should_Get_Author_By_Id()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "Bookstore")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Authors.Add(new Author(
                Id: 1,
                Name: "Adam",
                LastName: "Mickiewicz"
                ));
            context.SaveChanges();

            AuthorRepository authorRepository = new AuthorRepository(context);
            //when
            Optional<Author> author = authorRepository.GetAuthorById(1);

            //then
            Assert.NotNull(author.Value);
            Assert.Equal(1, author.Value.author_Id);
            Assert.Equal("Adam", author.Value.name);
            Assert.Equal("Mickiewicz", author.Value.lastName);
        }

        [Fact]
        public async Task AuthorRepository_Should_Get_Author_By_Name_And_LastName()
        {
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
             .UseInMemoryDatabase(databaseName: "Bookstore")
             .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Authors.Add(new Author(
                Id: 1,
                Name: "Adam",
                LastName: "Mickiewicz"
                ));
            context.Authors.Add(new Author(
               Id: 2,
               Name: "Wojtek",
               LastName: "Kowalczewski"
               ));
            context.SaveChanges();
            AuthorRepository authorRepository = new AuthorRepository(context);
            //when           
            Optional<Author> author = authorRepository.GetAuthorByNameAndLastname("Wojtek", "Kowalczewski");

            //then
            Assert.NotNull(author.Value);
            Assert.Equal(2, author.Value.author_Id);
            Assert.Equal("Wojtek", author.Value.name);
            Assert.Equal("Kowalczewski", author.Value.lastName);
        }


        [Fact]
        public async Task AuthorRepository_Should_Insert_Author()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "Bookstore")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);

            AuthorRepository authorRepository = new AuthorRepository(context);

            Author author = new Author(
                Id: 2,
                Name: "Mariusz",
                LastName: "Szczygieł"
                );
            //when
            authorRepository.InsertAuthor(author);
            Author authorFromDb = authorRepository.GetAuthorById(2).Value;

            //then
            Assert.NotNull(authorFromDb);
            Assert.Equal(2, authorFromDb.author_Id);
            Assert.Equal("Mariusz", authorFromDb.name);
            Assert.Equal("Szczygieł", authorFromDb.lastName);

        }

        [Fact]
        public async Task AuthorRepository_Should_Delete_Author()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "Bookstore")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Authors.Add(new Author(
              Id: 1,
              Name: "Adam",
              LastName: "Mickiewicz"
              ));
            context.Authors.Add(new Author(
               Id: 2,
               Name: "Mariusz",
               LastName: "Szczygieł"
               ));
            context.SaveChanges();

            AuthorRepository authorRepository = new AuthorRepository(context);

            Author author = new Author(
                Name: "Mariusz",
                LastName: "Szczygieł"
                );
            //when
            authorRepository.DeleteAuthor(author);
            Author authorFromDb = authorRepository.GetAuthorById(2).Value;

            //then
            Assert.Null(authorFromDb);


        }


        [Fact]
        public async Task AuthorRepository_Should_Delete_Author_By_Id()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "Bookstore")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Authors.Add(new Author(
              Id: 1,
              Name: "Adam",
              LastName: "Mickiewicz"
              ));
            context.Authors.Add(new Author(
               Id: 2,
               Name: "Mariusz",
               LastName: "Szczygieł"
               ));
            context.SaveChanges();

            AuthorRepository authorRepository = new AuthorRepository(context);

            //when
            authorRepository.DeleteAuthor(1);
            Author authorFromDb = authorRepository.GetAuthorById(1).Value;

            //then
            Assert.Null(authorFromDb);


        }

        [Fact]
        public async Task AuthorRepository_Should_Get_Authors_By_PageNumber()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "Bookstore")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Authors.Add(new Author(
                Id: 1,
                Name: "Adam",
                LastName: "Mickiewicz"
                ));
            context.Authors.Add(new Author(
                Id: 2,
                Name: "Wojtek",
                LastName: "Turlecki"
                ));
            context.Authors.Add(new Author(
                Id: 3,
                Name: "Batłomiej",
                LastName: "Kawka"
                ));
            context.SaveChanges();

            AuthorRepository authorRepository = new AuthorRepository(context);
            //when
            Optional<Author> author = authorRepository.GetAuthorById(1);

            //then
            Assert.NotNull(author.Value);
            Assert.Equal(1, author.Value.author_Id);
            Assert.Equal("Adam", author.Value.name);
            Assert.Equal("Mickiewicz", author.Value.lastName);
        }


    }
}
