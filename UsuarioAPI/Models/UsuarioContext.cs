using Microsoft.EntityFrameworkCore;
using UsuarioAPI.Models;
namespace ProductoAPI.Models
{
    public class UsuarioContext : DbContext
    {
        public UsuarioContext(DbContextOptions<UsuarioContext> options)
         : base(options)
        { }

        public DbSet<Usuario> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Usuario>().HasData(
                new Usuario
                {
                    Id = 1,
                    Nombre = "Lionel",
                    Apellido = "Messi",
                    Edad = "37"
                },
                new Usuario
                {
                    Id = 2,
                    Nombre = "Cristiano",
                    Apellido = "Ronaldo",
                    Edad = "39"
                }, 
                new Usuario
                {
                    Id = 3,
                    Nombre = "Scarlett",
                    Apellido = "Johansson",
                    Edad = "39"
                });
        }
    }
}
