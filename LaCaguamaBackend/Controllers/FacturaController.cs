using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class FacturaController : ControllerBase
    {
        private readonly IFacturaService _service;

        public FacturaController(IFacturaService service)
        {
            _service = service;
        }
        [HttpGet("GetAll/Tipo")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<HistorialFacturaDto>>> GetAllHistorialFactura()
        {
            var historias = await _service.GetAllHistorialFactura();
            return Ok(historias);
        }
        [HttpGet("GetAll/Fechas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<HistorialFacturaDto>>> GetAllHistorialFacturaFecha(DateTime inicio, DateTime final)
        {
            var historias = await _service.GetAllHistorialFacturaFecha(inicio,final);
            return Ok(historias);
        }
    }
}
