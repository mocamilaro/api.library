
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace api.library.DAL.Models
{
    public class Persons : AuditBase
    {
        [Required]
        public string? Doc_id { get; set; }
        public string? Name { get; set; }
        public long Tel_number { get; set; }

    }
}
