using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class BorrowsCreateDto
    {
        [Required(ErrorMessage = "La fecha de préstamo es obligatoria")]
        public DateTime Borrow_date { get; set; }

    }
}
