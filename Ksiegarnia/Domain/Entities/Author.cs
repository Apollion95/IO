using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Author
    {
        [Key]
        public int author_Id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public string lastName { get; set; }

        public virtual ICollection<Book> books { get; set;}

        public Author(int Id, string Name, string LastName)
        {
            (author_Id, name, lastName) = (Id, Name, LastName);
        }

        public Author()
        {

        }
    }
}
