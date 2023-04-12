using Microsoft.AspNetCore.Mvc;
using MinhaDemoMVC.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace MinhaDemoMVC.Controllers
{
   
    public class FilmeController : Controller
    {
       
        public IActionResult Index(string id, Guid categoria)
        {
            var filme = new Filme
            { 
                Titulo = "Oi",
                DataLancamento = DateTime.Now,
                Genero = null,
                Valor = 20000,
                Avaliacao = 10

            };

            return RedirectToAction("Privacy", filme);
            //return View();
        }

        
        public IActionResult Privacy(Filme filme)
        {
           if (ModelState.IsValid)
            {

            }

           foreach( var error in ModelState.Values.SelectMany(m => m.Errors))
            {
                Console.WriteLine(error.ErrorMessage);
            }

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
