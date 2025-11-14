using api.library.DAL.Models.Dtos;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private readonly IBookService _BookService;

        public BooksController(IBookService BookService)
        {
            _BookService = BookService;
        }

        public async Task<ActionResult<ICollection<BooksDto>>> GetBooksAsync()
        {
            var Books = await _BookService.GetBooksAsync();
            return Ok(Books); //http 200 con la lista de Bookas
        }
    }
}
