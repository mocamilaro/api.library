using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class CopiesDto
    {
        public int Id { get; set; }
        public string? Notes { get; set; }
        public bool Available { get; set; }

        [Required]
        public int Book { get; set; }

        [NotMapped] public Books? _Book { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
