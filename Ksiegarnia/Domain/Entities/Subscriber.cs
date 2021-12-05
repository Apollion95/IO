using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class Subscriber
    {
        [Key]
        [Required]
        public int sub_id { get; set; }
        [Required]
        public DateTime sub_start { get; set; }
        [Required]
        public virtual User user { get; set; }
        [Required]
        public DateTime sub_end { get; set; }
        public bool is_active { get; set; }

        
    }
}
