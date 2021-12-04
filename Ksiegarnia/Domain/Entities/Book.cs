using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Domain.Entities
{
    [Table(name:"Book")]
    public class Book
    {
        [Key]
        public int book_id { get; set; }
        [Required]
        public string name { get; set; }
        [Required]
        public DateTime releaseDate { get; set; }
        [Required]
        public virtual Author author { get; set; }
        [Required]
        public virtual Publisher publisher { get; set; }

        public virtual ICollection<Transactions> transactions { get; set; }

        public Book(int Id, string Name, DateTime ReleaseDate)
        {
            (book_id, name, releaseDate) = (Id, Name, ReleaseDate);
        }

        public Book()
        {

        }
    }
}