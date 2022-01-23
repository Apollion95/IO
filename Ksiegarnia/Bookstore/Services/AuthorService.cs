using Infrastructure.Repository.Interfaces;

namespace Bookstore.Services
{
    public class AuthorService
    {
        public IAuthorRepository authorRepository;


        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }


    }
}
