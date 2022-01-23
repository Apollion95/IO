namespace Ksiegarnia.Dtos
{
    public class PublisherDto
    {
  
        public int publisher_id { get; set; }
  
        public string name { get; set; }


        public PublisherDto(int Id, string Name)
        {
            (publisher_id, name) = (Id, Name);
        }
    }
}
