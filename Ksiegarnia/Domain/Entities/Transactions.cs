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

        public Transactions(int trans_id, DateTime date, double price, User user, Book book)
        {
            this.trans_id=trans_id;
            this.date=date;
            this.price=price;
            this.user=user;
            this.book=book;
        }

        [Key]
        public int trans_id { get; set; }

        public DateTime date { get; set; }

        public Double  price { get; set; }

        public virtual User user { get; set; }
        
        public virtual Book book { get; set; }

       
    }
}