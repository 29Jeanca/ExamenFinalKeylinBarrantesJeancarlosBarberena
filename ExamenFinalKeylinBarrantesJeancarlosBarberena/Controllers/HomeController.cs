using ExamenFinalKeylinBarrantesJeancarlosBarberena.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ExamenFinalKeylinBarrantesJeancarlosBarberena.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            paisesMasRicos pms = paisesMasRicos.listaRicos;
            return View(pms.Paises);
        }
        public IActionResult buscar(string texto)
        {
            paisesMasRicos pms = paisesMasRicos.listaRicos;
            var paises = pms.Paises.Where(x => x.nombrePais.Contains(texto));
            return View(paises);
        }
        public IActionResult VerPaises(int id)
        {
            paisesMasRicos pms = paisesMasRicos.listaRicos;
            Paises p = pms.Paises.Where(x=> x.ID==id).FirstOrDefault();
            if (p==null)
            {
                return NotFound();
            }
            else
            {
                return View(p);
            }
        }
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}