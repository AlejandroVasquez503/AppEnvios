using System.ComponentModel.DataAnnotations;

namespace appWebEnvio.Models
{
    public class Clientes
    {
        [Key]
        public int ClienteId { get; set; }

        [Required]
        public string Nombre { get; set; }

        public string Telefono { get; set; }
        public string Email { get; set; }
        public string Direccion { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public ICollection<Envios> Envios { get; set; }
    }
}
