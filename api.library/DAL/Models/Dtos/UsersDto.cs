using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models.Dtos
{
    public class UsersDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="El código de usuario es obligatorio")]
        public int User_code { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string? Password { get; set; }
        public int Person { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
