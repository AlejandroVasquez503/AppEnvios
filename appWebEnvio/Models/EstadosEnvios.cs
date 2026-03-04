using System.ComponentModel.DataAnnotations;

namespace appWebEnvio.Models
{
    public class EstadosEnvios
    {
        [Key]
        public int EstadoId { get; set; }

        [Required]
        public string NombreEstado { get; set; }

        public string Descripcion { get; set; }

        public ICollection<Envios> Envios { get; set; }
    }
}
