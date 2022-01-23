using Bookstore.Dtos;
using Domain.Entities;


namespace Bookstore.Mapper
{
    public class AuthorMapper
    {
        public Author convertToEntity(AuthorDto dto)
        {
            return  new Author(dto.author_Id, dto.name, dto.lastName);        
        }

        public AuthorDto convertToDto(Author entity)
        {
            return new AuthorDto(entity.author_Id, entity.name, entity.lastName);
        }
    }
}
