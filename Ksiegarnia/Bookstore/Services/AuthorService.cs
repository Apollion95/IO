using Bookstore.Dtos;
using Domain.Entities;
using Infrastructure.Repository.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Microsoft.CodeAnalysis;

namespace Bookstore.Services
{
    public class AuthorService
    {
        public IAuthorRepository authorRepository;


        public AuthorService(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        internal List<Author> getAuthors(int page)
        {
            return authorRepository.GetAuthors(page).ToList();
        }

        internal Author getAuthorById(int id)
        {
            Optional<Author> author = authorRepository.GetAuthorById(id);
            if (!author.HasValue)
                return null;
            return author.Value;
                
        }

        internal List<Book> getAuthorBooks(int id)
        {
            return authorRepository.GetAuthorBooks(id);
        }

        internal Author createAuthor(Author author)
        {
            if (!authorRepository.GetAuthorByNameAndLastname(author.name, author.lastName).HasValue)
                return null;
            authorRepository.InsertAuthor(new Author(author.name,author.lastName));

            return author;


        }

        internal void delete(Author author)
        {
            authorRepository.DeleteAuthor(author);
        }
    }
}
