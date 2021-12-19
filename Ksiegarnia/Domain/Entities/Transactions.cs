using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Numerics;

namespace Domain.Entities
{
    public class Transactions
    {
      
        public Transactions()
        {

        }
        [Key]
        public int trans_id { get; set; }

        public DateTime date { get; set; }

        public Double  price { get; set; }

        public virtual User user { get; set; }
        
        public virtual Book book { get; set; }

       
    }
}