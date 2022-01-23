using Domain.Entities;

namespace Bookstore.Dtos
{
    public class AuthorDto
    {
        
        public string name { get; set; }
      
        public string lastName { get; set; }

        public List<Book> books { get; set; }

        public AuthorDto(string name, string lastName)
        {

            this.name = name;
            this.lastName = lastName;
        }

        public AuthorDto(string name, string lastName, List<Book> books)
        {

            this.name = name;
            this.lastName = lastName;
            this.books = books;    
        }
        public AuthorDto()
        {

        }

    }
}
