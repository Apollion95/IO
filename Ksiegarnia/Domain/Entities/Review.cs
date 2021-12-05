using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Review
    {
        [Key]
        [Required]
        public int review_id { get; set; }
        public string review { get; set; }
        [Required]
        public int rating { get; set; }
        [Required]
        public virtual Book book { get; set; }
        [Required]
        public virtual User user {get;set;}

    }
}
