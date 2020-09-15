using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Exercicio3.Models;

namespace Exercicio3.Controllers
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
            ViewBag.Filmes = new List<string>()
            {
                "O Poderoso Chefão",
                "2001",
                "Se Beber, Não Case",
                "O Rei Leão",
                "Matrix"
            };

            return View();
        }

        [HttpPost]
        public IActionResult Enviar(List<string> nomeFilmes)
        {
            for (var i = 0; i < nomeFilmes.Count; i++) {
                Console.WriteLine($"Filme {i+1}: {nomeFilmes[i]}");
            }

            ViewBag.Filmes = nomeFilmes;

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
