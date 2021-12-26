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
    public class TransactionsRepositoryTest
    {
        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_By_Id()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {


                context.Transactions.Add(new Transactions { trans_id=1, price=100, date=new DateTime(2015, 10, 3) });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var user = new UserRepository(context);
                //Act
                var trans = tran.GetById(1);

                context.SaveChanges();


                //Assert
                Assert.Equal(1, trans.trans_id);
            }
        }
        /*[Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_By_User_Id()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {

                //var Book = new Book { book_id = 1, name = "Name", releaseDate = new DateTime(2010, 8, 4) };

                var User = new User { name = "Tomek", address = "address", email = "email", lastname = "lastname", password = "password", username="username", user_id = 4 };

                context.Transactions.Add(new Transactions { trans_id=2, price=100, date=new DateTime(2015, 10, 3), user=User });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var user = new UserRepository(context);
                //Act
                var users = user.GetUserById(4);

                context.SaveChanges();


                //Assert
                Assert.Equal(4, users.Value.user_id);

            }
        }

        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_By_BookName()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {

                var Book = new Book { book_id = 1, name = "Name", releaseDate = new DateTime(2010, 8, 4) };


                context.Transactions.Add(new Transactions { trans_id=3, price=100, date=new DateTime(2015, 10, 3), book=Book });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var book = new BookRepository(context);
                //Act
                var books = book.GetBookByName("Name");

                context.SaveChanges();


                //Assert
                Assert.Equal("Name", books.Value.name);

            }
        }

        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_Add()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;

            // Insert seed data into the database using one instance of the context
            using (var context = new BookStoreContext(options))
            {


                context.Transactions.Add(new Transactions { trans_id=4, price=100, date=new DateTime(2015, 10, 3) });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var book = new BookRepository(context);
                //Act
                var books = book.GetBookByName("Name");

                context.SaveChanges();


                //Assert
                Assert.NotNull(tran);

            }
        }
        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_Update()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;

            using (var context = new BookStoreContext(options))
            {


                context.Transactions.Add(new Transactions { trans_id=5, price=100, date=new DateTime(2015, 10, 3) });





                context.SaveChanges();
            }

            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var trans = tran.GetById(5);
                tran.Delete(trans);

                context.SaveChanges();


                //Assert
                Assert.NotNull(trans);


            }
        }
        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_Delete()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;


            using (var context = new BookStoreContext(options))
            {


              
                context.Transactions.Add(new Transactions { trans_id=6, price=100, date=new DateTime(2015, 10, 3) });
                context.Transactions.Add(new Transactions { trans_id=7, price=100, date=new DateTime(2015, 10, 3) });
                context.Transactions.Add(new Transactions { trans_id=8, price=100, date=new DateTime(2015, 10, 3) });





                context.SaveChanges();
            }
            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

          
                var trans2 = tran.GetById(6);
                var trans3 = tran.GetById(7);
                var trans4 = tran.GetById(8);
             

                context.SaveChanges();


                //Assert
            
                Assert.Equal(6, trans2.trans_id);
                Assert.Equal(7, trans3.trans_id);
                Assert.Equal(8, trans4.trans_id);
                

            }
        }
        [Fact]
        public async Task TranscabtionRepository_Should_Get_Transactions_GetTransactions()
        {
            var options = new DbContextOptionsBuilder<BookStoreContext>().EnableSensitiveDataLogging()
          .UseInMemoryDatabase(databaseName: "TransactionMemory")
          .Options;



            // Use a clean instance of the context to run the test
            using (var context = new BookStoreContext(options))
            {
                var tran = new TransactionsRepository(context);

                var trans = tran.GetById(1);
                trans.price = 220;
                trans.date = new DateTime(2017, 5, 3);
                tran.Update(trans);

                context.SaveChanges();


                //Assert
                Assert.Equal(1, trans.trans_id);
                Assert.Equal(220, trans.price);
                Assert.Equal(new DateTime(2017, 5, 3), trans.date);

            }
        }*/
    }
}
