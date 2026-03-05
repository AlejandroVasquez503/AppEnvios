using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace appWebEnvio.Models
{
    public class Auditorias
    {
        [Key]
        public int AuditoriaId { get; set; }

        [MaxLength(100)]
        public string TablaAfectada { get; set; }

        public int RegistroId { get; set; }

        [MaxLength(50)]
        public string Accion { get; set; }

        public int? AdministradorId { get; set; }

        [ForeignKey("AdministradorId")]
        public Administradores Administrador { get; set; }

        public DateTime FechaAccion { get; set; } = DateTime.Now;
    }
}
