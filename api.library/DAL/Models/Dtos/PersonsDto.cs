using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models.Dtos
{
    public class PersonsDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El número de documento es obligatorio")]
        public string? Doc_id { get; set; }

        [Required(ErrorMessage = "El nombre es obligatorio")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "El nombre del teléfono es obligatorio")]
        public long Tel_number { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
