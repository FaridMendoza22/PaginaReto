namespace PaginaReto.Models
{
    public class Empleado
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        // Agrega otras propiedades según sea necesario
    }
    
    public interface IEmpleadoRepository
    {
        IEnumerable<Empleado> GetAllEmpleados();
        Empleado GetEmpleado(int id);
        void AddEmpleado(Empleado empleado);
        void UpdateEmpleado(Empleado empleado);
        void DeleteEmpleado(int id);
    }
}
