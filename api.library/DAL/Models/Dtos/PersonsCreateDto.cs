using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models.Dtos
{
    public class PersonsCreateDto
    {
        [Required(ErrorMessage = "El número de documento es obligatorio")]
        public string? Doc_id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El nombre del teléfono es obligatorio")]
        [MinLength (10, ErrorMessage = "El número mínimo de caracteres es 10")]
        public long Tel_number { get; set; }
    }
}
