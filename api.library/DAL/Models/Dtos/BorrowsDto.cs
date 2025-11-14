using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class BorrowsDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="La fecha de préstamo es obligatoria")]
        public DateTime Borrow_date { get; set; }
        public int User { get; set; }
        [NotMapped] public Users? _User { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
