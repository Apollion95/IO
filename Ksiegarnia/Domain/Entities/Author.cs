namespace Domain.Entities
{
    public class Author
    {
        public int author_Id { get; set; }

        public string name { get; set; }

        public string lastName { get; set; }

        public Author(int Id, string Name, string LastName)
        {
            (author_Id, name, lastName) = (Id, Name, LastName);
        }
    }
}
