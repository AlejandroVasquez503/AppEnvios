using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class Envios
    {
        [Key]
        public int EnvioId { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes Clientes { get; set; }

        [Required]
        public int DestinatarioId { get; set; }

        [ForeignKey("DestinatarioId")]
        public Destinatarios Destinatarios { get; set; }

        [Required]
        public int EstadoId { get; set; }

        [ForeignKey("EstadoId")]
        public EstadosEnvios EstadosEnvios { get; set; }

        public DateTime FechaEnvio { get; set; }
        public DateTime? FechaEntrega { get; set; }

        public decimal Costo { get; set; }

        public ICollection<Paquetes> Paquetes { get; set; }
    }
}
