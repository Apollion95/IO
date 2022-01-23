namespace Ksiegarnia.Dtos
{
    public class ReviewDto
    {
      
        public int review_id { get; set; }
        public string review { get; set; }
    
        public int rating { get; set; }
   
        public virtual BookDto book { get; set; }
  
        public virtual UserDto user { get; set; }
    }
}
