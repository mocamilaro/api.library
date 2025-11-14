using api.library.DAL.Models.Dtos;
using api.library.Services.IServices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace api.library.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private readonly IUserService _UserService;

        public UsersController(IUserService UserService)
        {
            _UserService = UserService;
        }

        public async Task<ActionResult<ICollection<UsersDto>>> GetUsersAsync()
        {
            var Users = await _UserService.GetUsersAsync();
            return Ok(Users); //http 200 con la lista de Useras
        }
    }
}
