using api.library.DAL.Models.Dtos;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BorrowsController : ControllerBase
    {
        private readonly IBorrowService _BorrowService;

        public BorrowsController(IBorrowService BorrowService)
        {
            _BorrowService = BorrowService;
        }

        public async Task<ActionResult<ICollection<BorrowsDto>>> GetBorrowsAsync()
        {
            var Borrows = await _BorrowService.GetBorrowsAsync();
            return Ok(Borrows); //http 200 con la lista de Borrowas
        }
    }
}
