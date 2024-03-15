using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginaReto.Models;

namespace PaginaReto.Pages.Shared
{
    public class DeleteModel : PageModel
    {
        private readonly IEmpleadoRepository _empleadoRepository;

        public DeleteModel(IEmpleadoRepository empleadoRepository)
        {
            _empleadoRepository = empleadoRepository;
        }

        [BindProperty]
        public int Id { get; set; }

        public IActionResult OnGet(int id)
        {
            var empleado = _empleadoRepository.GetEmpleado(id);
            if (empleado == null)
            {
                return NotFound();
            }

            return Page();
        }

        public IActionResult OnPost()
        {
            var empleado = _empleadoRepository.GetEmpleado(Id);
            if (empleado == null)
            {
                return NotFound();
            }

            _empleadoRepository.DeleteEmpleado(Id);
            return RedirectToPage("./Index");
        }
    }
}
