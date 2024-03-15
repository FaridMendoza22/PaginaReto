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
            // Aqu� puedes llenar la lista de empleados desde la base de datos u otro origen de datos
            ListaEmpleados = ObtenerEmpleadosDesdeLaBaseDeDatos();
        }

        // M�todo de ejemplo para obtener empleados desde la base de datos
        private List<Empleado> ObtenerEmpleadosDesdeLaBaseDeDatos()
        {
            // Aqu� va la l�gica para obtener los empleados desde la base de datos
            return new List<Empleado>(); // Por ahora, simplemente retornamos una lista vac�a
        }
    }
}
