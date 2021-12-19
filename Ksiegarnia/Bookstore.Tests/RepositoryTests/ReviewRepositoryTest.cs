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
    public class ReviewRepositoryTest
    {
        [Fact]
        public async Task ReviewRepository_Should_Get_Review_By_ID()

        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Reviews.Add(new Review(
              ));

            ReviewRepository reviewRepository = new ReviewRepository(context);
            //when
            Publisher rewiev = ReviewRepository.GetById(1);
            //then

            Assert.NotNull(review);
        
        }
    }
}

