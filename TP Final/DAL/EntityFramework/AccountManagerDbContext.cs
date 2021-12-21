using TP_Final.DAL.EntityFramework.Mapping;
using TP_Final.Domain;
using Microsoft.EntityFrameworkCore;

namespace TP_Final.DAL.EntityFramework
{
    public class AccountManagerDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Server=localhost;Port=5432;User Id=postgres;Password=123;Database=postgres");
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {          
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
            modelBuilder.ApplyConfiguration(new EjemplarConfiguration());
            modelBuilder.ApplyConfiguration(new LibroConfiguration());
            modelBuilder.ApplyConfiguration(new NotificacionConfiguration());
            modelBuilder.ApplyConfiguration(new PrestamoConfiguration());
        }

        public DbSet<Usuario> Usuarios { get; set; }

        public DbSet<Libro> Libros { get; set; }

        public DbSet<Ejemplar> Ejemplares { get; set; }

        public DbSet<Prestamo> Prestamos { get; set; }

        public DbSet<Notificacion> Notifiaciones { get; set; }


    }
}