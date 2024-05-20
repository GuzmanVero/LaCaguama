using LaCaguamaFrontend.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace LaCaguamaFrontend.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Login()
        {
            return View(new LoginModel());
        }
        [HttpPost]
        public async Task<IActionResult> Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                string token = await AuthenticateUser(model);
                if (!string.IsNullOrEmpty(token))
                {
                    // Guarda el token en algún lugar, por ejemplo en un cookie o session
                    HttpContext.Session.SetString("JWTToken", token);
                    return RedirectToAction("Index", "Home"); // Redirige a la página principal
                }
                ModelState.AddModelError(string.Empty, "Intento de login inválido.");
            }
            return View(model);
        }
        private async Task<string> AuthenticateUser(LoginModel model)
        {
            var httpClient = new HttpClient();
            var content = new StringContent(JsonConvert.SerializeObject(model), Encoding.UTF8, "application/json");
            var response = await httpClient.PostAsync("https://localhost:44347/Login/Validar", content);

            if (response.IsSuccessStatusCode)
            {
                var token = await response.Content.ReadAsStringAsync();
                // Asegúrate de ajustar esto según cómo tu API devuelve el token
                return token;
            }
            return null;
        }
    }
}
