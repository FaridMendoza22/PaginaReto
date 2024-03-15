using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using PaginaReto.Models;

namespace PaginaReto.Pages.Shared
{
    public class DetailsModel : PageModel
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public int Id { get; set; }



        public void OnGet()
        {
            Nombre = "John";
            Apellido = "Doe";
        }
    }
}
