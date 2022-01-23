using Bookstore.Dtos;
using Domain.Entities;


namespace Bookstore.Mapper
{
    public class AuthorMapper
    {
        public Author convertToEntity(AuthorDto dto)
        {
            if(dto.books==null)
                return new Author(dto.name, dto.lastName);
            return  new Author(dto.name, dto.lastName, dto.books);        
        }

        public AuthorDto convertToDto(Author entity)
        {
            if(entity.books==null)
                return  new AuthorDto(entity.name, entity.lastName);
            return new AuthorDto(entity.name, entity.lastName, entity.books.ToList());
        }
    }
}
