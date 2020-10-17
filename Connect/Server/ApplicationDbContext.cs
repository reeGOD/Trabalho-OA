using Connect.Shared;
using Microsoft.EntityFrameworkCore;

namespace Connect.Server
{
     public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }

        public DbSet<Lanche> Lanches { get; set; }
    }
}