using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class DetailsDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="La fecha de devolución es obligatoria")]
        public DateTime Return_date { get; set; }
        public int Borrow { get; set; }
        public int Copy { get; set; }

        [NotMapped] public Copies? _Copy { get; set; }
        [NotMapped] public Borrows? _Borrow { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
