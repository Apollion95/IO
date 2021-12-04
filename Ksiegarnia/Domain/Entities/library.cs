using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Library
    {
        public Library(int user_id, int book_id)
        {
            this.user_id=user_id;
            this.book_id=book_id;
        }
        [Key]
        public int library_id { get; set; }
        [Required]
        
        public int user_id{ get; set; }
        [Required]
        public int book_id{ get; set;}

      
    }
}