using LibraryAPI.Interfaces;
using LibraryAPI.Entities;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Data
{
    
    public class AuthorRepository(LibraryContext context) : IAuthorRepository
    {
        public async Task<IEnumerable<Author>> GetAllAsync()
        {
            return await context.Authors.ToListAsync();
        }

        public async Task<Author> GetByIdAsync(int id)
        {
            return await context.Authors.FindAsync(id) ?? throw new InvalidOperationException();
        }

        public async Task AddAsync(Author author)
        {
            context.Authors.Add(author);
            await context.SaveChangesAsync();
        }

        public async Task UpdateAsync(Author author)
        {
            context.Entry(author).State = EntityState.Modified;
            await context.SaveChangesAsync();
        }

        public async Task DeleteAsync(int id)
        {
            var author = await context.Authors.FindAsync(id);
            if (author != null)
            {
                context.Authors.Remove(author);
                await context.SaveChangesAsync();
            }
        }
    }
}