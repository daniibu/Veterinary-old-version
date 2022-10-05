using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProcedureController : ControllerBase
    {
        private readonly IProcedureRepository _procedureRepository;

        public ProcedureController(IProcedureRepository procedureRepository)
        {
            _procedureRepository = procedureRepository;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<ProcedureFullDto>>> GetProcedureList()
        {
            var procedures = await _procedureRepository.GetAll();
            return Ok(procedures);
        }
    }
}
