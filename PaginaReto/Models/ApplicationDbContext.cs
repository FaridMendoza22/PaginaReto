using Microsoft.EntityFrameworkCore;

namespace PaginaReto.Models
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        // Define DbSet para cada entidad en tu base de datos
        public DbSet<Empleado> Empleados { get; set; }
        // Agrega otras propiedades DbSet para cada entidad en tu base de datos
    }
}
