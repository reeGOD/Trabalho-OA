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

        public DbSet<LancheIngrediente> LancheIngredientes { get; set; }
        
        protected override void OnModelCreating (ModelBuilder modelBuilder){

            modelBuilder.Entity<LancheIngrediente>()
                .HasKey(t => new {t.LancheId, t.IngredienteId});

            modelBuilder.Entity<LancheIngrediente>()
                .HasOne(pt => pt.Lanche)
                .WithMany(p => p.LancheIngredientes)
                .HasForeignKey(pt => pt.LancheId);

            modelBuilder.Entity<LancheIngrediente>()
                .HasOne(pt => pt.Ingrediente)
                .WithMany(t => t.LancheIngredientes)
                .HasForeignKey(pt => pt.IngredienteId);
        }
    }
}