using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserRolController : ControllerBase
    {
        private readonly IUserRolRepository _userRolRepository;

        public UserRolController(IUserRolRepository userRolRepository)
        {
            _userRolRepository = userRolRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserRolFullDto>>> GetUserRolList()
        {
            var userRoles = await _userRolRepository.GetAll();
            return Ok(userRoles);
        }
    }
}
