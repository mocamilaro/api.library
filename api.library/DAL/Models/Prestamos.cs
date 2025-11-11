using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Prestamos : AuditBase
    {
        public DateTime Fecha_prestamo { get; set; }
        public int Usuario { get; set; }

        [NotMapped] public Usuarios? _Usuario { get; set; }
    }
}
