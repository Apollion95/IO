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
            //given

            //ar connectionString = ConfigurationManager.Configuration.GetConnectionString("DefaultConnection");


            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase("SubscruberMemory")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Subscribers.Add(new Subscriber(
                sub_id: 1,
                sub_start: new DateTime(2015, 11, 10),
                sub_end: new DateTime(2020, 4, 1),
                is_active: true,
                user: new User(2, "Pawel")));



            SubscriberRepository SubscriberRepository = new SubscriberRepository(context);
            //when
            Optional<Subscriber> sub = SubscriberRepository.GetById(1);
            //then

            Assert.NotNull(sub.Value);
            Assert.Equal(1, sub.Value.sub_id);
            Assert.Equal(new DateTime(2015, 11, 16), sub.Value.sub_start);
            Assert.Equal(new DateTime(2016, 11, 15), sub.Value.sub_end);
            Assert.Equal(true, sub.Value.is_active);
        }

    }
}
