using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Repositories;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PetTypeController : ControllerBase
    {
        private readonly PetTypeRepository _petTypeRepository;

        public PetTypeController(PetTypeRepository petTypeRepository)
        {
            _petTypeRepository = petTypeRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<PetFullDto>>> GetPetTypeList()
        {
            var petTypes = await _petTypeRepository.GetAll();
            return Ok(petTypes);
        }
    }
}
