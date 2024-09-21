using Microsoft.EntityFrameworkCore;
namespace ProductoAPI.Models
{
    public class ProductoContext : DbContext
    {
        public ProductoContext(DbContextOptions<ProductoContext> options) 
         : base(options)
        { }

        public DbSet<Producto> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Producto>().HasData(
                new Producto
                {
                    Id = 1,
                    Nombre = "Laptoop",
                    Categoria = "Electronica",
                    Descripcion = "Alto rendimiento"
                },
                new Producto
                {
                    Id = 2,
                    Nombre = "Telefono",
                    Categoria = "Electronica",
                    Descripcion = "Nueva generacion"
                }, new Producto
                {
                    Id = 3,
                    Nombre = "Silla de escritorio",
                    Categoria = "Muebles",
                    Descripcion = "Silla muy comoda"
                });
        }
    }
}
