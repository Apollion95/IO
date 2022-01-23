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
        public async Task SubscriberRepository_Should_Add_Subscriber()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
           .UseInMemoryDatabase(databaseName: "SubscruberMemory")
           .Options;


            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);

                var cityT = new CityRepository(context);
                //Act
                var sub = sut.GetById(1);
                var city = cityT.GetCityByName("Jelesnia");

                //Assert
                Assert.Equal(1, sub.sub_id);
            }
        }
        [Fact]
        public async Task SubscriberRepository_Should_Update_Subscriber()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
           .UseInMemoryDatabase(databaseName: "SubscruberMemory")
           .Options;


            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);

                var cityT = new CityRepository(context);
                //Act
                var sub = sut.GetById(1);
                sub.is_active = false;
                sub.sub_start=new DateTime(2016, 4, 3);
                sub.sub_end=new DateTime(2017, 5, 3);
                context.Subscribers.Update(sub);
                context.SaveChanges();
                

                //Assert
                Assert.Equal(1, sub.sub_id);
                Assert.Equal(false, sub.is_active);
                Assert.Equal(new DateTime(2016,4,3),sub.sub_start);
                Assert.Equal(new DateTime(2017,5,3),sub.sub_end);
            }
        }

        [Fact]
        public async Task SubscriberRepository_Should_Delete_Subscriber()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
           .UseInMemoryDatabase(databaseName: "SubscruberMemory")
           .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {


                context.Subscribers.Add(new Subscriber { sub_id= 3, sub_start = new DateTime(2015, 11, 10), sub_end = new DateTime(2020, 4, 1), is_active= true, });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);

                var cityT = new CityRepository(context);
                //Act
                var sub = sut.GetById(3);
                sut.Delete(sub);
                var sub2 = sut.GetById(3);
                context.SaveChanges();


                //Assert
                Assert.Equal(null, sub2);
            }
        }




        [Fact]
        public async Task SubscriberRepository_Should_Get_Subscriber_By_Id()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
            .UseInMemoryDatabase(databaseName: "SubscruberMemory")
            .Options;

            // Insert seed data into the database using one instance of the context
        

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);
        
                var cityT = new CityRepository(context);
                //Act
                var sub = sut.GetById(1);
                var city = cityT.GetCityByName("Jelesnia");

                //Assert
                Assert.Equal(1, sub.sub_id);
                Assert.Equal("Jelesnia", city.Value.city);
                Assert.Equal("34-340", city.Value.postal_code);
            }
        }


        [Fact]
        public async Task SubscriberRepository_Should_Get_Subscribers()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
            .UseInMemoryDatabase(databaseName: "SubscruberMemory")
            .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {


                context.Subscribers.Add(new Subscriber { sub_id= 2, sub_start = new DateTime(2015, 11, 10), sub_end = new DateTime(2020, 4, 1), is_active= true, });
                context.Subscribers.Add(new Subscriber { sub_id= 4, sub_start = new DateTime(2015, 11, 10), sub_end = new DateTime(2020, 4, 1), is_active= true, });
                context.Subscribers.Add(new Subscriber { sub_id= 5, sub_start = new DateTime(2015, 11, 10), sub_end = new DateTime(2020, 4, 1), is_active= true, });
                context.Subscribers.Add(new Subscriber { sub_id= 6, sub_start = new DateTime(2015, 11, 10), sub_end = new DateTime(2020, 4, 1), is_active= true, });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var sut = new SubscriberRepository(context);

                var cityT = new CityRepository(context);
                //Act
                var sub = sut.GetSubscriber();
                var sub1 = sub.SingleOrDefault(x => x.sub_id == 1);
                var sub2 = sub.SingleOrDefault(x => x.sub_id == 2);
                var sub3 = sub.SingleOrDefault(x => x.sub_id == 3);
                var sub4 = sub.SingleOrDefault(x => x.sub_id == 4);
                var sub5 = sub.SingleOrDefault(x => x.sub_id == 5);

                //Assert
                Assert.Equal(1, sub1.sub_id);
                Assert.Equal(2, sub2.sub_id);
                Assert.Equal(3, sub3.sub_id);
                Assert.Equal(4, sub4.sub_id);
                Assert.Equal(5, sub5.sub_id);
                Assert.Equal(false, sub1.Equals(null));
                Assert.Equal(false, sub2.Equals(null));
                Assert.Equal(false, sub3.Equals(null));
                Assert.Equal(false, sub4.Equals(null));
                Assert.Equal(false, sub5.Equals(null));

            }
        }


        [Fact]
        public async Task SubscriberRepository_Should_Get_Subscriber_By_User_Id()
        {

            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
            .UseInMemoryDatabase(databaseName: "SubscruberMemory")
            .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {
                var city = new City { postal_code="34-340", city= "Jelesnia" };
                var user = new User { user_id=2, username="Kow", name="Pawel", lastname="Kowlaski", address="address", email="email", password="password", postal_code=city };
                context.Subscribers.Add(new Subscriber { sub_id= 1, sub_start = new DateTime(2015, 11, 10), user = user, sub_end = new DateTime(2020, 4, 1), is_active= true, });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
               
                var user = new UserRepository(context);
                var cityT = new CityRepository(context);
                //Act
               
                var usert = user.GetUserById(2);
               

                //Assert
                Assert.Equal(2, usert.Value.user_id);
                Assert.Equal("Pawel", usert.Value.name);
                Assert.Equal("Kowlaski", usert.Value.lastname);
                Assert.Equal("Kow", usert.Value.username);
                Assert.Equal("email", usert.Value.email);
                Assert.Equal("address", usert.Value.address);
                Assert.Equal("password", usert.Value.password);

            }
        }
        


    }
}
