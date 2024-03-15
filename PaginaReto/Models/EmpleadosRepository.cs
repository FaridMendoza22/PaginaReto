using Microsoft.AspNetCore.Mvc;

namespace PaginaReto.Models
{
    public class EmpleadoRepository : IEmpleadoRepository
    {
        private readonly ApplicationDbContext _context;

        public EmpleadoRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Empleado> GetAllEmpleados()
        {
            return _context.Empleados.ToList();
        }

        public Empleado GetEmpleado(int id)
        {
            return _context.Empleados.FirstOrDefault(e => e.Id == id);
        }

        public void AddEmpleado(Empleado empleado)
        {
            _context.Empleados.Add(empleado);
            _context.SaveChanges();
        }

        public void UpdateEmpleado(Empleado empleado)
        {
            _context.Empleados.Update(empleado);
            _context.SaveChanges();
        }

        public void DeleteEmpleado(int id)
        {
            var empleadoToDelete = _context.Empleados.FirstOrDefault(e => e.Id == id);
            if (empleadoToDelete != null)
            {
                _context.Empleados.Remove(empleadoToDelete);
                _context.SaveChanges();
            }
        }
    }
}