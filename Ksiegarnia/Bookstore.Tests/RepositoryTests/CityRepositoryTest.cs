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
    public class CityRepositoryTest
    {
        [Fact]
        public async Task AuthorRepository_Should_Get_Cities()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            BookStoreContext context = new BookStoreContext(dbOptions);
            context.Cities.Add(new City(

                ));

            CityRepository cityRepository = new CityRepository(context);
            //when
            Optional<Author> author = cityRepository.GetCities(1);
            //then

            Assert.NotNull(author.Value);
        }
    }
}
