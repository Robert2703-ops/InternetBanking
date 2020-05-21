using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TrabalhoJoseInternetBanking2.Models;

namespace TrabalhoJoseInternetBanking2.Controllers
{
    public class ClienteController : Controller
    {
        [HttpGet ()]
        public IActionResult DadosPessoais()
        {
            var NovoCliente =  new ClienteCorrentista();
            return View(NovoCliente);
        }

        [HttpPost()]
        public IActionResult DadosPessoais(ClienteCorrentista NovoCliente)
        {
            return View(NovoCliente);
        } 
    }
}