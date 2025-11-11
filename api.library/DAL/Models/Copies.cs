using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Copies : AuditBase
    {
        public string? Notes { get; set; }
        public bool Available { get; set; }

        [Required]
        public int Book { get; set; }

        [NotMapped] public Books? _Book { get; set; }
    }
}
