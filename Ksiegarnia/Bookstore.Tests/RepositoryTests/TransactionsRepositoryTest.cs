using Domain.Entities;
using Infrastructure.Data;
using Infrastructure.Repository;
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
    public class TransactionsRepositoryTest
    {
        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_By_Id()
        {
            //given

            //ar connectionString = ConfigurationManager.Configuration.GetConnectionString("DefaultConnection");


            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase("TransactionMemory")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Transactions.Add(new Transactions(
               trans_id: 1,date: new DateTime(2020,11,3),price: 100, user: new User(1,"Pawel"),book:new Book(1,"Harry",new DateTime(1555,3,1)
                )));



            TransactionsRepository SubscriberRepository = new TransactionsRepository(context);
            //when
            Optional<Transactions> sub = SubscriberRepository.GetById(1);
            //then

            Assert.NotNull(sub.Value);
            Assert.Equal(1, sub.Value.trans_id);
            Assert.Equal(100, sub.Value.price);
            Assert.Equal(new User(1, "Pawel"),sub.Value.user);
            Assert.Equal(new Book(1, "Harry", new DateTime(1555, 3, 1)),sub.Value.book);
            Assert.Equal(new DateTime(2020, 11, 3), sub.Value.date);
        }
    }
}
