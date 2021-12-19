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
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Publishers.Add(new Publisher(
                Id: 1,
                Name: "PWN"
                ));

            PublisherRepository publisherRepository = new PublisherRepository(context);
            //when
            Publisher publisher = publisherRepository.GetById(1);
            //then

            Assert.NotNull(publisher);
            Assert.Equal(1, publisher.publisher_id);
            Assert.Equal("PWN", publisher.name);
       
        }
    }
}
