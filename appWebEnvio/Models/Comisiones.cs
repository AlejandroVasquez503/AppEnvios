using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class Comisiones
    {
        [Key]
        public int ComisionId { get; set; }

        [Required]
        public int EnvioId { get; set; }

        [ForeignKey("EnvioId")]
        public Envios Envios { get; set; }

        [Column(TypeName = "decimal(5,2)")]
        public decimal Porcentaje { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal MontoComision { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;
    }
}
