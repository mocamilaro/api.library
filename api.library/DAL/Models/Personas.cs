
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace api.library.DAL.Models
{
    public class Personas : AuditBase
    {
        [Required]
        public string? Cedula { get; set; }
        public string? Nombre { get; set; }
        public long Numero { get; set; }

    }
}
