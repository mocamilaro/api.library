using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.library.DAL.Models.Dtos
{
    public class CopiesCreateDto
    {
        public string? Notes { get; set; }
        public bool Available { get; set; }


    }
}
