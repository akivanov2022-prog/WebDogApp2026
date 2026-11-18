using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

using WebDogApp.Infrastructure.Data.Domain;
using WebDogApp.Infrastucture.WebDogApp.Infrastructure.Data.Domain;

namespace WebApplication2.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
          Database.EnsureCreated();
        }
        public DbSet<Dog> Dogs { get; set; }
        public DbSet<Breed> Breeds { get; set; }
    }
}
