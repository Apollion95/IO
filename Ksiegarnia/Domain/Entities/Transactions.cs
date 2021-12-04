using System;
using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Transactions
    {
        public Transactions(int trans_id, DateTime date, int user_id, int book_id)
        {
            this.trans_id=trans_id;
            this.date=date;
            this.user_id=user_id;
            this.book_id=book_id;
        }
        [Key]
        public int trans_id { get; set; }

        public DateTime date { get; set; }

        public int user_id { get; set; }

        public int book_id { get; set; }

       
    }
}