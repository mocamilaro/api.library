using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Details : AuditBase
    {
        [Key] public int Id_detail { get; set; }
        public DateTime Return_date { get; set; }
        public int Borrow { get; set; }
        public int Copy { get; set; }

        [NotMapped] public Copies? _Copy { get; set; }
        [NotMapped] public Borrows? _Borrow { get; set; }
    }
}
