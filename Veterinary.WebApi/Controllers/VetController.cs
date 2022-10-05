using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VetController : ControllerBase
    {
        private readonly IVetRepository _vetRepository;

        public VetController(IVetRepository vetRepository)
        {
            _vetRepository = vetRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VetFullDto>>> GetVetList()
        {
            var vets = await _vetRepository.GetAll();
            return Ok(vets);
        }
    }
}
