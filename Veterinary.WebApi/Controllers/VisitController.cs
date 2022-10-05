using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitController : ControllerBase
    {
        private readonly IVisitRepository _visitRepository;

        public VisitController(IVisitRepository visitRepository)
        {
            _visitRepository = visitRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitFullDto>>> GetVisitList()
        {
            var visits = await _visitRepository.GetAll();
            return Ok(visits);
        }
    }
}
