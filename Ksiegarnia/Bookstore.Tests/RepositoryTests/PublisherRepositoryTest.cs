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
    public class PublisherRepositoryTest
    {

        [Fact]
        public async Task PublisherRepository_Should_Get_Publisher_By_ID()   
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>()
         .UseInMemoryDatabase(databaseName: "MovieListDatabase")
         .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {
                context.Publishers.Add(new Publisher { name  = "Tomek",publisher_id = 1});
                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new PublisherRepository(context);
                //Act
                var movies = sut.GetById(1);

                //Assert
                Assert.Equal(1, movies.publisher_id);
            }
        }
    }
}
