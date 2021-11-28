namespace Domain.Entities
{
    public class Store
    {
        public int book_id { get; set; }

        public string name { get; set; }

        public DateTime releaseDate { get; set; }

        public Store(int Id, string Name, DateTime ReleaseDate)
        {
            (book_id, name, releaseDate) = (Id, Name, ReleaseDate);
        }
    }
}
