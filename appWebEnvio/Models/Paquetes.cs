using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class Paquetes
    {
        [Key]
        public int PaqueteId { get; set; }

        [Required]
        public int EnvioId { get; set; }

        [ForeignKey("EnvioId")]
        public Envios Envios { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public decimal Peso { get; set; }
    }
}
