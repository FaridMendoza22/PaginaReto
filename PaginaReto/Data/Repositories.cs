using Microsoft.AspNetCore.Mvc;
using PaginaReto.Models;

namespace PaginaReto.Data
{
    public class Repositories : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
    public class EmpleadoRepository : IEmpleadoRepository
    { 
    
        private readonly ApplicationDbContext _context;

        public EmpleadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Empleado> ObtenerTodos()
        {
            return _context.Empleados.ToList();
        }

        public Empleado ObtenerPorId(int id)
        {
            return _context.Empleados.FirstOrDefault(e => e.Id == id);
        }

        public void Agregar(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public void Actualizar(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            _context.SaveChanges();
        }

        public void Eliminar(int id)
        {
            var empleado = _context.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleado != null)
            {
                _context.Empleados.Remove(empleado);
                _context.SaveChanges();
            }
        }
    }
}
