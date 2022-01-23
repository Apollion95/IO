namespace Ksiegarnia.Dtos
{
    public class LibraryDto
    {

        public int library_id { get; set; }


        public virtual UserDto user { get; set; }

        public virtual BookDto book { get; set; }
    }
}
