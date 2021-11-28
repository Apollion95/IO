using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    internal class Review
    {
        [Key]
        [Required]
        public int review_id { get; set; }
        public string review { get; set; }
        [Required]
        public int rating { get; set; }
        [Required]
        public int book_id { get; set; }
        [Required]
        public int user_id{get;set;}
    }
}
