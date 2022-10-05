using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserFullDto>>> GetUserList()
        {
            var users = await _userRepository.GetAll();
            return Ok(users);
        }
    }
}
