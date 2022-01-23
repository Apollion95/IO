namespace Ksiegarnia.Dtos
{
    public class BookDto
    {
   
        public int book_id { get; set; }
    
        public string name { get; set; }
       
        public DateTime releaseDate { get; set; }
     
        public virtual AuthorDto author { get; set; }
       
        public virtual PublisherDto publisher { get; set; }

        public virtual ICollection<TransactionsDto> transactions { get; set; }

        public BookDto(int Id, string Name, DateTime ReleaseDate)
        {
            (book_id, name, releaseDate) = (Id, Name, ReleaseDate);
        }
    }
}
