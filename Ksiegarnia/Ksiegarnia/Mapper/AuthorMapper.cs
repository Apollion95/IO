using Domain.Entities;
using Ksiegarnia.Dtos;

namespace Ksiegarnia.Mapper
{
    public class AuthorMapper
    {
        private Author convertToEntity(AuthorDto dto)
        {
            return  new Author(dto.author_Id, dto.name, dto.lastName);        
        }


    }
}
