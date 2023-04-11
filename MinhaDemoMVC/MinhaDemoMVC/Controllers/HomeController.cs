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
        //Sobrecarga de rotas para encurtamento de navegação e passagem de parâmetro via rota
        //para implementar a segurança ao passar o tipo de dado que a rota deve receber.
        [Route("")]
        [Route("pagina-inicial")]
        [Route("pagina-inicial/{id:int}/{categoria:guid}")]
        public IActionResult Index(string id, Guid categoria)
        {
            return View();
        }

        [Route("privacidade")]
        [Route("politica-de-privacidade")]
        public IActionResult Privacy()
        {
            //return Json("Eu sou uma string convertida para JSON. {'nome':'Eduardo'}");

            //Download de arquivo.
            var fileBytes = System.IO.File.ReadAllBytes(@"C:\Users\eduar\Documents\arquivo.txt");
            var fileName = "ola.txt";
            return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);

            //return Content("Qualquer coisa!");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        [Route("erro-encontrado")]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
