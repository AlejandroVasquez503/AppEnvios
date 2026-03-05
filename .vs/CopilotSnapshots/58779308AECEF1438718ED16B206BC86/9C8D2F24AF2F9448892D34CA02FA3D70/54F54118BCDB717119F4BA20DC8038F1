using System.ComponentModel.DataAnnotations;

namespace appWebEnvio.Models
{
    public class Destinatarios
    {
        [Key]
        public int DestinatarioId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public string Direccion { get; set; }
        public string Ciudad { get; set; }
        public string Pais { get; set; }

        public ICollection<Envios> Envios { get; set; }
    }
}
