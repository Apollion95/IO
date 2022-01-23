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
        public Subscriber(int sub_id, DateTime sub_start, User user,DateTime sub_end, bool is_active)
        {
            this.sub_id=sub_id;
            this.sub_start=sub_start;
            this.sub_end=sub_end;
            this.is_active=is_active;
            this.user.user_id=user.user_id;
        }
        public Subscriber()
        {

        }

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
