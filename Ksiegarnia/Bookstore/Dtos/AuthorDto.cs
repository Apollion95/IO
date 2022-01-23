namespace Bookstore.Dtos
{
    public class AuthorDto
    {
        public int author_Id { get; set; }
        
        public string name { get; set; }
      
        public string lastName { get; set; }

        public AuthorDto(int id, string name, string lastName)
        {
            author_Id = id;
            this.name = name;
            this.lastName = lastName;
        }
    }
}
