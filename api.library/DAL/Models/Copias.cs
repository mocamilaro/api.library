using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Copias : AuditBase
    {
        public string? Notas { get; set; }
        public bool Disponible { get; set; }

        [Required]
        public int Libro { get; set; }

        [NotMapped] public Libros? _Libro { get; set; }
    }
}
