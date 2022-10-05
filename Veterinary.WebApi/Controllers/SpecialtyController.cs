using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SpecialtyController : ControllerBase
    {
        private readonly ISpecialtyRepository _specialtyController;

        public SpecialtyController(ISpecialtyRepository specialtyController)
        {
            _specialtyController = specialtyController;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<SpecialtyFullDto>>> GetSpecialtyList()
        {
            var specialties = await _specialtyController.GetAll();
            return Ok(specialties);
        }
    }
}
