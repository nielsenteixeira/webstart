﻿using System.Web.Mvc;
using Patterns.Core;
using Restfulie.Server;
using Restfulie.Server.Results;

namespace Patterns.Web.Controllers
{
    [ActAsRestfulie]
    public class PessoaController : Controller
    {
        private readonly IRepositorio<Pessoa> todasAsPessoas;

        public PessoaController()
        {
            
        }

        public PessoaController(IRepositorio<Pessoa> repositorioDePessoas)
        {
            todasAsPessoas = repositorioDePessoas;
        }

        [HttpGet]
        public ActionResult Lista()
        {
            return new OK(todasAsPessoas.Lista());
        }
        
        [HttpGet]
        public ActionResult ListaComNome(string nome)
        {
            return new OK(repositorioDePessoas.QueryableLista().where(p=> p.Nome.Contains("Hamon")); 
        }
    }
}
