using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Estacionamento.Models;

namespace Estacionamento.Controllers
{   [ApiController]
    [Route("[controller]")]
    public class EstacionamentoController : ControllerBase
    {
        private readonly Contexto _contexto;

        public EstacionamentoController(Contexto contexto){
                    _contexto=contexto;
        }
            [HttpPost]
            public IActionResult Create(Cliente cliente){
                _contexto.Add(cliente);
                _contexto.SaveChanges();
                return Ok(cliente);
            }
            [HttpPost("CriarVeiculo")]
            public IActionResult Create(Veiculo veiculo){

                _contexto.Add(veiculo);
                _contexto.SaveChanges();
                return Ok(veiculo);
            }
    }
}