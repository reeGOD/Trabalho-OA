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
        
        public DbSet<Endereco> Enderecos { get; set; }

        public DbSet<Ingrediente> Ingredientes { get; set; }

        public DbSet<Pedido> Pedidos { get; set; }
        
        public DbSet<Item> Items { get; set; }

        protected override void OnModelCreating (ModelBuilder modelBuilder){

            modelBuilder.Entity<Item>()
                .HasKey(t => new {t.LancheId, t.PedidoId});

            modelBuilder.Entity<Item>()
                .HasOne(pt => pt.Pedido)
                .WithMany(p => p.Item)
                .HasForeignKey(pt => pt.PedidoId);

            modelBuilder.Entity<Item>()
                .HasOne(pt => pt.Lanche)
                .WithMany(t => t.Item)
                .HasForeignKey(pt => pt.LancheId);
        }
    }
}