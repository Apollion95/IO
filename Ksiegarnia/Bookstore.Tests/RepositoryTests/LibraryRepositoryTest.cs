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
    public class LibraryRepositoryTest
    {
        [Fact]
        public async Task AuthorRepository_Should_Get_Library()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            LibraryRepository libraryRepository = new LibraryRepository();
            //when
            Optional<Library> library = libraryRepository.GetLibrary(1, 1);
            //then

            Assert.NotNull(library.Value);
            Assert.Equal(1, library.Value.user);
            Assert.Equal(1, library.Value.name);
        }

        [Fact]
        public async Task AuthorRepository_Should_Get_Library_By_Id()
        {
            //given
            var dbOptions = new DbContextOptionsBuilder<BookStoreContext>()
            .UseInMemoryDatabase(databaseName: "EmployeeDataBase")
            .Options;

            LibraryRepository libraryRepository = new LibraryRepository();
            //when
            Optional<Library> library = libraryRepository.GetLibraryByUserId();
            //then

            Assert.NotNull(library.Value);
            Assert.Equal(1, library.Value.user);
        }
    }
}
