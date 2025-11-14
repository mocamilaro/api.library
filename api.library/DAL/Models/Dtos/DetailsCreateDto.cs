using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class DetailsCreateDto
    {
        [Required(ErrorMessage = "La fecha de devolución es obligatoria")]
        public DateTime Return_date { get; set; }

    }
}
