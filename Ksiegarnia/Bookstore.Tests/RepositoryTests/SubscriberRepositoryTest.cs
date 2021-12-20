using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
using Microsoft.CodeAnalysis;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Bookstore.Tests.RepositoryTests
{
    public class SubscriberRepositoryTest
    {

        [Fact]
        public async Task SubscriberRepository_Should_Get_Subscriber_By_Id()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
            .UseInMemoryDatabase(databaseName: "SubscruberMemory")
            .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {
                var user = new User(1, "Pawel",new City("34-340","Jelesnia"),"Kowlaski","Ble","asdas","asdasd","asda2sd");
                context.Subscribers.Add(new Subscriber { sub_id= 1, sub_start = new DateTime(2015, 11, 10), user = user, sub_end = new DateTime(2020, 4, 1),  is_active= true,  });
               




                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);
                //Act
                var movies = sut.GetById(1);

                //Assert
                Assert.Equal(1, movies.sub_id);
            }
        }

    }
}
