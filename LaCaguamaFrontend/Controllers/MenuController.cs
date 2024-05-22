using Microsoft.AspNetCore.Mvc;

namespace LaCaguamaFrontend.Controllers
{
    public class MenuController : Controller
    {
        public IActionResult Menu()
        {
            return View();
        }
    }
}
