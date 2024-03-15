using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginaReto.Models;

namespace PaginaReto.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public PrivacyModel(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        [BindProperty]
        public Empleado Empleado { get; set; }

        public IActionResult OnGet()
        {
            // Aquí puedes llenar Nombre y Apellido si es necesario
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            // Agrega el nuevo empleado a la base de datos
            _empleadoRepository.AddEmpleado(Empleado);

            // Redirige al usuario a la página de lista de empleados después de crear el empleado
            return RedirectToPage("/Index");
        }
    }
}

