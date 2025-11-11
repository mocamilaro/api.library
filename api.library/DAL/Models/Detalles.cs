using api.library.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib_entidades.Modelos
{
    public class Detalles
    {
        [Key] public int Id_detalle { get; set; }
        public DateTime Fecha_entrega { get; set; }
        public int Prestamo { get; set; }
        public int Copia { get; set; }

        [NotMapped] public Copias? _Copia { get; set; }
        [NotMapped] public Prestamos? _Prestamo { get; set; }
    }
}
