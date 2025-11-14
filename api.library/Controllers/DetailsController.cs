using api.library.DAL.Models.Dtos;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DetailssController : ControllerBase
    {
        private readonly IDetailService _DetailsService;

        public DetailssController(IDetailService DetailsService)
        {
            _DetailsService = DetailsService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ICollection<DetailsDto>>> GetDetailssAsync()
        {
            var Detailss = await _DetailsService.GetDetailsAsync();
            return Ok(Detailss); //http 200 con la lista de Detailsas
        }
    }
}
