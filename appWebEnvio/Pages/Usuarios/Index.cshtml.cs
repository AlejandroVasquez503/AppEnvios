using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using appWebEnvio.Data;
using appWebEnvio.Models;
using ModelClientes = appWebEnvio.Models.Clientes;

namespace appWebEnvio.Pages.Clientes
{
    public class IndexModel : PageModel
    {
        private readonly AppDbContext _context;

        public IndexModel(AppDbContext context)
        {
            _context = context;
        }

        public IList<ModelClientes> ClientesList { get; set; }

        public async Task OnGetAsync()
        {
            ClientesList = await _context.Clientes.AsNoTracking().ToListAsync();
        }
    }
}
