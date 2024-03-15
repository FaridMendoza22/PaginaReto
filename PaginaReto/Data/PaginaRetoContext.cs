using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using PaginaReto.Models;

namespace PaginaReto.Data
{
    public class PaginaRetoContext : DbContext
    {
        public PaginaRetoContext (DbContextOptions<PaginaRetoContext> options)
            : base(options)
        {
        }

        public DbSet<PaginaReto.Models.Empleado> Empleado { get; set; } = default!;
    }
}
