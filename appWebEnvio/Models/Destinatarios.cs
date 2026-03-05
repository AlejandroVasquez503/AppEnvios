using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class Destinatarios
    {
        [Key]
        public int DestinatarioId { get; set; }
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; }

        [Required]
        public int ClienteId { get; set; }

        [ForeignKey("ClienteId")]
        public Clientes Clientes { get; set; }

        [MaxLength(20)]
        public string Telefono { get; set; }

        [MaxLength(255)]
        public string Direccion { get; set; }

        [MaxLength(100)]
        public string Ciudad { get; set; }

        [MaxLength(100)]
        public string Pais { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public DateTime? FechaModificacion { get; set; }

        public ICollection<Envios> Envios { get; set; }
    }
}
