using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models
{
    public class Users : AuditBase
    {
        public int User_code { get; set; }
        public string? Mail { get; set; }
        public string? Password { get; set; }
        public int Person { get; set; }

        [NotMapped] public Persons? _Person { get; set; } //Cuando hereda
    }
}
