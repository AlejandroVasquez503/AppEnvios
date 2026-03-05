using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class HistorialEstados
    {
        [Key]
        public int HistorialId { get; set; }

        [Required]
        public int EnvioId { get; set; }

        [ForeignKey("EnvioId")]
        public Envios Envios { get; set; }

        [Required]
        public int EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        public EstadosEnvios EstadosEnvios { get; set; }

        public DateTime FechaCambio { get; set; } = DateTime.Now;
    }
}
