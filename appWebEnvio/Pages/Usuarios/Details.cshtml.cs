using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using appWebEnvio.Data;
using appWebEnvio.Models;
using ModelClientes = appWebEnvio.Models.Clientes;

namespace appWebEnvio.Pages.Clientes
{
    public class DetailsModel : PageModel
    {
        private readonly AppDbContext _context;

        public DetailsModel(AppDbContext context)
        {
            _context = context;
        }

        public ModelClientes Cliente { get; set; }

        public async Task<IActionResult> OnGetAsync(int id)
        {
            Cliente = await _context.Clientes.FirstOrDefaultAsync(c => c.ClienteId == id);

            if (Cliente == null)
            {
                return NotFound();
            }

            return Page();
        }
    }
}
