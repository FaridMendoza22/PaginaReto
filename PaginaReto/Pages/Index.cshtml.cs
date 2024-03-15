using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginaReto.Models;

namespace PaginaReto.Pages
{
    public class IndexModel : PageModel
    {
        public List<Empleado> ListaEmpleados { get; set; }

        public void OnGet()
        {
            // Aquí puedes llenar la lista de empleados desde la base de datos u otro origen de datos
            ListaEmpleados = ObtenerEmpleadosDesdeLaBaseDeDatos();
        }

        // Método de ejemplo para obtener empleados desde la base de datos
        private List<Empleado> ObtenerEmpleadosDesdeLaBaseDeDatos()
        {
            // Aquí va la lógica para obtener los empleados desde la base de datos
            return new List<Empleado>(); // Por ahora, simplemente retornamos una lista vacía
        }
    }
}
