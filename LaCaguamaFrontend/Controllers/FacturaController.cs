using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class FacturaController : Controller
    {
        public IActionResult Historial()
        {
            return View();
        }
    }
}
