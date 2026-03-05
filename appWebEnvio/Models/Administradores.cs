using System.ComponentModel.DataAnnotations;

namespace appWebEnvio.Models
{
    public class Administradores
    {
        [Key]
        public int AdministradorId { get; set; }

        [Required]
        [MaxLength(50)]
        public string Nombre { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(100)]
        public string Password { get; set; }

        public DateTime FechaRegistro { get; set; } = DateTime.Now;

        public DateTime? FechaModificacion { get; set; }
    }
}
