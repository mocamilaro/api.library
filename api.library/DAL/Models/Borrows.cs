using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Borrows : AuditBase
    {
        public DateTime Borrow_date { get; set; }
        public int User { get; set; }

        [NotMapped] public Users? _User { get; set; }
    }
}
