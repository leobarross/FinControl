using FinControl.Models;
using Microsoft.EntityFrameworkCore;

namespace FinControl.Data
{
    public class FinControlDbContext : DbContext
    {
        public FinControlDbContext(DbContextOptions<FinControlDbContext> options) : base(options) { }

        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Despesa> Despesas { get; set; }
        public DbSet<Receita> Receitas { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Despesa>()
                .Property(d => d.Valor)
                .HasColumnType("decimal(18,2)"); // Especifique precisão e escala

            modelBuilder.Entity<Receita>()
                .Property(r => r.Valor)
                .HasColumnType("decimal(18,2)"); // Especifique precisão e escala
        }
    }
}
