using CamKyscn.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;


namespace CamKyscn.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Paquete>()
                .HasMany(b => b.Bandas)
                .WithOne();
            modelBuilder.Entity<Paquete>()
                .HasMany(b => b.Fotos)
                .WithOne();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost,1433;Database=Camaras;User Id=sa;Password=Gato1412;").EnableSensitiveDataLogging(true);
        }

        public DbSet<Banda> Bandas { get; set; }
        public DbSet<Paquete> Paquetes { get; set; }
        public DbSet<Foto> Fotos { get; set; }
    }
}
