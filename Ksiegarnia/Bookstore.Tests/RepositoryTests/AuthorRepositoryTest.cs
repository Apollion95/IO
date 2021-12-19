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
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Books.Add(new Author(
                Id: 1,
                Name: "Adam",
                LastName: "Mickiewicz"
                ));

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
        public async Task AuthorRepository_Should_Add_Author()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
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
            //then
            Author authorFromDb = authorRepository.GetAuthorById(2).Value;
            Assert.NotNull(authorFromDb);
            Assert.Equal(2, authorFromDb.author_Id);
            Assert.Equal("Mariusz", authorFromDb.name);
            Assert.Equal("Szczygieł", authorFromDb.lastName);

        }
    }
}
