using LibraryAPI.Interfaces;
using LibraryAPI.Entities;
namespace LibraryAPI.Services
{
    public class AuthorService(IAuthorRepository authorRepository)
    {
        public async Task<IEnumerable<Author>> GetAllAuthorsAsync()
        {
            return await authorRepository.GetAllAsync();
        }

        public async Task<Author> GetAuthorByIdAsync(int id)
        {
            return await authorRepository.GetByIdAsync(id);
        }

        public async Task AddAuthorAsync(Author author)
        {
            await authorRepository.AddAsync(author);
        }

        public async Task UpdateAuthorAsync(Author author)
        {
            await authorRepository.UpdateAsync(author);
        }

        public async Task DeleteAuthorAsync(int id)
        {
            await authorRepository.DeleteAsync(id);
        }
    }
}