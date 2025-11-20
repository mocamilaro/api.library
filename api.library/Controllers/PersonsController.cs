using api.library.DAL.Models.Dtos;
using api.library.DAL.Models;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPersonService _personService;

        public PersonsController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]

        public async Task<ActionResult<ICollection<PersonsDto>>> GetPersonsAsync()
        {
            var personsDto = await _personService.GetPersonsAsync();
            return Ok(personsDto); //http 200 con la lista de personas
        }

        [HttpGet("{id:int}", Name = "GetPersonAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<ActionResult<PersonsDto>> GetPersonAsync(int id)
        {
            var personDto = await _personService.GetPersonByIdAsync(id);
            return Ok(personDto); //http 200 con la lista de personas
        }

        [HttpPost(Name = "CreatePersonAsync")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status409Conflict)]

        public async Task<ActionResult<PersonsDto>> CreatePersonDto([FromBody] PersonsCreateDto personsCreateDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            try
            {
                var createdPerson = await _personService.CreatePersonAsync(personsCreateDto);
                // Retorna un estado 201 Created con la ubicación del nuevo recurso
                
                return CreatedAtRoute("GetPersonAsync", //1er parámetro: nombre de la ruta
                    new { id = createdPerson.Id },          //2do parámetro: valores de los parámetros de la ruta
                    createdPerson);                         //3er parámetro: el objeto creado
            }

            catch (InvalidOperationException ex) when (ex.Message.Contains("Ya existe"))
            {
                return Conflict(new { ex.Message });
            }

            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, "Error al crear la persona");
            }

           

        }
    }
}
