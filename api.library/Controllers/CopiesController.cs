using api.library.DAL.Models.Dtos;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CopiessController : ControllerBase
    {
        private readonly ICopyService _CopiesService;

        public CopiessController(ICopyService CopiesService)
        {
            _CopiesService = CopiesService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        public async Task<ActionResult<ICollection<CopiesDto>>> GetCopiessAsync()
        {
            var Copiess = await _CopiesService.GetCopiesAsync();
            return Ok(Copiess); //http 200 con la lista de Copiesas
        }
    }
}
