using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
   
    public class User
    {
        public User(int user_id, string name)
        {
            this.user_id=user_id;
            this.name=name;
        }

        [Key]
        public int user_id { get; set; }

        [Required]
        [MaxLength(45)]
        public string name { get; set; }


        public string postal_code { get; set; }
        public City City { get; set; }

        [MaxLength(45)]
        public string lastname { get; set; }

        [MaxLength(45)]
        public string username { get; set; }

        [MaxLength(45)]
        public string email { get; set; }


        [MaxLength(45)]
        public string? address { get; set; }

        [MaxLength(45)]
        public string password { get; set; }



        public User(int user_id, string name, string postal_code, City city, string lastname, string username, string email, string? address, string password)
        {
            this.user_id=user_id;
            this.name=name;
            this.postal_code=postal_code;
            City=city;
            this.lastname=lastname;
            this.username=username;
            this.email=email;
            this.address=address;
            this.password=password;
        }


    }
}
