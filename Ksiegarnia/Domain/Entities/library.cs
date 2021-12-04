using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Library
    {
        
        [Key]
        public int library_id { get; set; }
        [Required]
        
        public virtual User user{ get; set; }
        [Required]
        public virtual Book book{ get; set;}

      
    }
}