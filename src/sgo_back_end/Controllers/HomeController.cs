using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using sgo_back_end.Models;
using SGO_Sistema_de_Gestao_ONGs.Models;
using System.Diagnostics;

namespace sgo_back_end.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;

        public HomeController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            Dashboard dashboard = new Dashboard();

            dashboard.voluntarios_count = _context.Voluntarios.Count();
            dashboard.doadores_count = _context.Doadores.Count();
            return View(dashboard);
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