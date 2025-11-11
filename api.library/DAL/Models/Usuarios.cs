using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Usuarios : AuditBase
    {
        public int Cod_usuario { get; set; }
        public string? Correo { get; set; }
        public string? Contraseña { get; set; }
        public int Persona { get; set; }

        [NotMapped] public Personas? _Persona { get; set; } //Cuando hereda
    }
}
