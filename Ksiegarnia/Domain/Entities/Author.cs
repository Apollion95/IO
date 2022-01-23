using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    public class Author
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
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

        public Author(string Name, string LastName)
        {
            (name, lastName) = (Name, LastName);
        }

        public Author(string Name, string LastName, List<Book> Books)
        {
            (name, lastName,books) = (Name, LastName, Books);
            
        }
    }
}
