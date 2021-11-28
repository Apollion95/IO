namespace Domain.Entities
{
    public class Library
    {
        public int user_id{ get; set; }

        public int book_id{ get; set;}

        public Library(int Id, string Name)
        {
            (user_id, book_id) = (user, book);
        }
    }
}