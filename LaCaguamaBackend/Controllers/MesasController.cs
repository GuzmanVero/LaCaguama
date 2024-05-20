using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class MesasController : ControllerBase
    {
        private readonly IMesaService _service;

        public MesasController(IMesaService service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<MesasDto>>> GetAllMesas()
        {
            var bebida = await _service.GetAllMesas();
            return Ok(bebida);
        }
    }
}
