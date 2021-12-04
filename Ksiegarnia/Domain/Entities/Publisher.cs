using System.ComponentModel.DataAnnotations;

namespace Domain.Entities
{
    public class Publisher
    {
        [Key]
        public int publisher_id { get; set; }
        [Required]
        public string name { get; set;}
        

        public Publisher(int Id, string Name)
        {
            (publisher_id, name) = (Id, Name);
        }

        public Publisher()
        {

        }
    }
}
