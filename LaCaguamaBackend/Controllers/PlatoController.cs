using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class PlatoController : ControllerBase
    {
        private readonly IPlatoService _service;

        public PlatoController(IPlatoService service)
        {
            _service = service;
        }
        [HttpGet("GetAll")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PlatoDto>>> GetAllPlato()
        {
            var extras = await _service.GetAllPlato();
            return Ok(extras);
        }
        [HttpGet("SearchPlatos")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PlatoDto>>> GetAllPlatoWithName(string nombre)
        {
            var bebida = await _service.GetAllPlatoWithName(nombre);
            return Ok(bebida);
        }
        [HttpPost("InsertPlato")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PlatoDto>>> InsertPlato(string nombre, string descripcion, decimal precio, string NombreExtra)
        {
            var bebida = await _service.InsertPlato(nombre,descripcion,precio, NombreExtra);
            return Ok(bebida);
        }
    }
}
