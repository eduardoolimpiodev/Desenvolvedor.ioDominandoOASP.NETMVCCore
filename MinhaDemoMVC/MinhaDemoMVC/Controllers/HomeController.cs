using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Controllers
{
    // A rota vazia deve estar somente em uma Controller, é indicado que fique na Controller da página incial.
    [Route("")]
    [Route("gestao-clientes")]
    public class HomeController : Controller
    {
        [Route("")]
        [Route("pagina-inicial")]
        public IActionResult Index(string id, string categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
