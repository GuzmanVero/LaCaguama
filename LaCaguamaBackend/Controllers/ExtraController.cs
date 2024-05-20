using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExtraController : ControllerBase
    {
        private readonly IExtraService _service;

        public ExtraController(IExtraService service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ExtrasDto>>> GetAllExtra()
        {
            var extras = await _service.GetAllExtras();
            return Ok(extras);
        }
        [HttpGet("SearchExtras")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ExtrasDto>>> GetAllEstrasWithName(string nombre)
        {
            var extras = await _service.GetAllEctraWithName(nombre);
            return Ok(extras);
        }
        [HttpPost("InsertExtra")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ExtrasDto>>> InsertExtra(string nombre, decimal precio)
        {
            var extras = await _service.InsertExtra(nombre, precio);
            return Ok(extras);
        }
    }
}
