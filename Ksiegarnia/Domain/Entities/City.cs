using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    
    public class City
    {


        [Key]
        [Required]
        [MaxLength(10)]
        public string postal_code { get; set; }

        [Required]
        [MaxLength(45)]
        public string city { get; set; }

        public City(string postal_code, string city)
        {
            this.postal_code=postal_code;
            this.city=city;
        }

    }
}
