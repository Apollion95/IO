namespace Domain.Entities
{
    public class Transactions
    {
        public int trans_id{ get; set; }

        public datetime date{ get; set;}
 	
	public int user_id{ get; set;}

 	public int book_id{ get; set;}

        public Transactions(trans_id, date, user_id, book_id)
        {
            (trans_id, date, user_id, book_id) = (transaction, date, user, book);
        }
    }
}