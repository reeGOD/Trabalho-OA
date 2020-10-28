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

        public DbSet<Sandwich> Sandwiches { get; set; }
        
        public DbSet<Address> Addresses { get; set; }

        public DbSet<Order> Orders { get; set; }

        public DbSet<Category> Categories { get; set; }

        public DbSet<OrderDetail> OrderDetails { get; set; }
        
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<OrderDetail>()
                .HasKey(p => new {p.OrderId, p.SandwichId});

            modelBuilder.Entity<OrderDetail>()
                .HasOne(pd => pd.Order)
                .WithMany(pr => pr.OrderDetails)
                .HasForeignKey(pd => pd.OrderId);
            
            modelBuilder.Entity<OrderDetail>()
                .HasOne(pd => pd.Sandwich)
                .WithMany(pr => pr.OrderDetails)
                .HasForeignKey(pd => pd.SandwichId);                
        }

    }
}