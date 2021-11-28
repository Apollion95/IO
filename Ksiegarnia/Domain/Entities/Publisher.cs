namespace Domain.Entities
{
    public class Publisher
    {
        public int publisher_id { get; set; }

        public string name { get; set;}

        public Publisher(int Id, string Name)
        {
            (publisher_id, name) = (Id, Name);
        }
    }
}
