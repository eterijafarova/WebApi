
using LibraryAPI.Interfaces;
using LibraryAPI.Services;
using LibraryAPI.Data;
using Microsoft.EntityFrameworkCore;

namespace LibraryAPI.Extensions
{
    public static class ServiceExtensions
    {
        public static void AddInfrastructure(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<LibraryContext>(options =>
                options.UseSqlServer(configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IAuthorRepository, AuthorRepository>();
        }

        public static void AddCoreServices(this IServiceCollection services)
        {
            services.AddScoped<AuthorService>();
        }
    }
}