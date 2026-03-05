using appWebEnvio.Models;
using Microsoft.EntityFrameworkCore;

namespace appWebEnvio.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
        {
        }

        public DbSet<Clientes> Clientes { get; set; }
        public DbSet<Destinatarios> Destinatarios { get; set; }
        public DbSet<EstadosEnvios> EstadosEnvio { get; set; }
        public DbSet<Envios> Envios { get; set; }
        public DbSet<Paquetes> Paquetes { get; set; }

    }
}
