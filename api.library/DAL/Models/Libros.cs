using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models
{
    public class Libros : AuditBase
    {
        public int Cod_libro { get; set; }
        public string? Nombre_libro { get; set; }
        public DateTime Fecha_publicacion { get; set; }
        public string? Autor { get; set; }
    }
}
