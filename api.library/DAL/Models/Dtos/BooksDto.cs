using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models.Dtos
{
    public class BooksDto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "El código del libro es obligatorio")]
        public int Book_code { get; set; }

        [Required(ErrorMessage = "El nombre del libro es obligatorio")]
        public string? Book_Name { get; set; }
        public DateTime Publication_date { get; set; }

        [Required(ErrorMessage = "El autor del libro es obligatorio")]
        public string? Author { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ModifiedDate { get; set; }

    }
}
