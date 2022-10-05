using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetController : ControllerBase
    {
        private readonly IPetRepository _petRepository;

        public PetController(IPetRepository petRepository)
        {
            _petRepository = petRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetFullDto>>> GetPetList()
        {
            var pets = await _petRepository.GetAllPet();
            return Ok(pets);

        }
    }
}
