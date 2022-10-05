using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Veterinary.Core.DTOs;
using Veterinary.Infrastructure.Services;

namespace Veterinary.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VisitDetailController : ControllerBase
    {
        private readonly IVisitDetailRepository _visitDetail;

        public VisitDetailController(IVisitDetailRepository visitDetail)
        {
            _visitDetail = visitDetail;
        }
        [HttpGet]
        public async Task<ActionResult<IEnumerable<VisitDetailFullDto>>> GetVisitDetailList()
        {
            var visitDetails = await _visitDetail.GetAll();
            return Ok(visitDetails);
        }
    }
}
