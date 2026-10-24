using Microsoft.AspNetCore.Mvc;
using TitanesDelValle.Models;

namespace TitanesDelValle.Controllers
{
    public class AspiranteController : Controller
    {
        // GET: /Aspirante/Registro (Muestra el formulario)
        [HttpGet]
        public IActionResult Registro()
        {
            return View();
        }

        // POST: /Aspirante/Registro (Procesa el formulario)
        [HttpPost]
        public IActionResult Registro(Aspirante aspirante)
        {
            if (ModelState.IsValid)
            {
                RepositorioAspirantes.Agregar(aspirante);
                // Redirige al panel de listado después de registrarse
                return RedirectToAction("Panel");
            }
            return View(aspirante);
        }

        // GET: /Aspirante/Panel (El panel donde se ven todos los aspirantes)
        [HttpGet]
        public IActionResult Panel()
        {
            var lista = RepositorioAspirantes.ObtenerTodos();
            return View(lista);
        }
    }
}