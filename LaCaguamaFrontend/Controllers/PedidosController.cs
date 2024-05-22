using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class PedidosController : Controller
    {
        public IActionResult Mesas()
        {
            return View();
        }

        public IActionResult Pedido()
        {
            return View();
        }

        public IActionResult Ordenes()
        {
            return View();
        }
    }
}
