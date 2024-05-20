using LaCaguamaBackend.Application.Dtos;
using LaCaguamaBackend.Domain.Interface;
using LaCaguamaBackend.Domain.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaBackend.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class BebidaController : ControllerBase
    {
        private readonly IBebidaService _service;

        public BebidaController(IBebidaService service)
        {
            _service = service;
        }
        [HttpPost("InsertBebida")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InventarioBebidaProveedorDto>>> GetBebida(string proveedor, string categoria, string nombreBebida,
            int stock, decimal precioUnitario)
        {
            var bebida = await _service.GetBebida(proveedor, categoria, nombreBebida, stock, precioUnitario);
            return Ok(bebida);
        }
        [HttpGet("GetAll/bebidasMenu")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BebidasDto>>> GetBebidas()
        {
            var bebida = await _service.GetBebidas();
            return Ok(bebida);
        }
        [HttpGet("SearchBebidas")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<BebidasDto>>> GetAllBebidas(string nombre)
        {
            var bebida = await _service.GetAllBebidas(nombre);
            return Ok(bebida);
        }
    }
}
