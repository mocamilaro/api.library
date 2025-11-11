using api.library.DAL.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Lib_entidades.Modelos
{
    public class Details
    {
        [Key] public int Id_detail { get; set; }
        public DateTime Return_date { get; set; }
        public int Borrow { get; set; }
        public int Copy { get; set; }

        [NotMapped] public Copies? _Copy { get; set; }
        [NotMapped] public Borrows? _Borrow { get; set; }
    }
}
