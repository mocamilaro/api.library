using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models.Dtos
{
    public class UsersCreateDto
    {
        [Required(ErrorMessage = "El código de usuario es obligatorio")]
        public int User_code { get; set; }

        [Required(ErrorMessage = "El correo es obligatorio")]
        public string? Mail { get; set; }

        [Required(ErrorMessage = "La contraseña es obligatoria")]
        public string? Password { get; set; }

    }
}
