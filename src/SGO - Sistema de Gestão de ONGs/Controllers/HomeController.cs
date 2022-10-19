using Microsoft.AspNetCore.Mvc;
using SGO___Sistema_de_Gestão_de_ONGs.Models;
using System.Diagnostics;

namespace SGO___Sistema_de_Gestão_de_ONGs.Controllers
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
            return View();
        }

        public IActionResult Home()
        {
            return View();
        }

        public IActionResult Suporte()
        {
            return View();
        }
        public IActionResult CadastroVoluntario()
        {
            return View();
        }

        public IActionResult ListaVoluntario()
        {
            return View();
        }

        public IActionResult CadastroDoador()
        {
            return View();
        }

        public IActionResult ListaDoador()
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