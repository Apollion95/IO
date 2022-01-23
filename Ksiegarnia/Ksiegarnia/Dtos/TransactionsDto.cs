namespace Ksiegarnia.Dtos
{
    public class TransactionsDto
    {
        public TransactionsDto(int trans_id, DateTime date, double price, UserDto user, BookDto book)
        {
            this.trans_id=trans_id;
            this.date=date;
            this.price=price;
            this.user=user;
            this.book=book;
        }

     
        public int trans_id { get; set; }

        public DateTime date { get; set; }

        public Double price { get; set; }

        public virtual UserDto user { get; set; }

        public virtual BookDto book { get; set; }
    }
}
