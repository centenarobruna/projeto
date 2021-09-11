using App.Domain.Entities;
using App.Domain.Interfaces.Application;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Api.Controllers


{
    [ApiController]
    [Route("[controller]")]
    public class CidadeController : Controller
    {
        private ICidadeService _service;

        public CidadeController(ICidadeService service)
        {
            _service = service;
        }

        [HttpGet("ListaCidades")]
        public JsonResult ListaCidades()
        {
            return Json(_service.listaCidades());
        }

        [HttpGet("BuscaPorCep")]
        public JsonResult BuscaPorCep(string id)
        {
            return Json(_service.BuscaPorCep(id));
        }
        [HttpPost("Salvar")]
        public JsonResult Salvar(string Cep, String Uf, string Nome)
        {
            var obj = new Cidade
            {
                Cep = Cep,
                Uf = Uf,
                Nome = Nome,
           
            };
            _service.Salvar(obj);
            return Json(true);
        }
    }
}