using System.ComponentModel.DataAnnotations;

namespace api.library.DAL.Models
{
    public class Books : AuditBase
    {
        public int Book_code { get; set; }
        public string? Book_Name { get; set; }
        public DateTime Publication_date { get; set; }
        public string? Author { get; set; }
    }
}
