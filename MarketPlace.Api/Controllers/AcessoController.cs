using MarketPlace.Api.DataBase;
using MarketPlace.Api.Interface;
using MarketPlace.Api.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AcessoController 
    {
        private readonly IAcessoService _acessoService;

        public AcessoController(IAcessoService acessoService)
        {
            _acessoService = acessoService;
        }

        [HttpGet]
        [Route("ObterAcesso")]
        public AcessoTable ObterAcesso(int id)
        {
            return _acessoService.ObterAcesso(id);
        }

        [HttpPost]
        [Route("InserirAcesso")]
        public bool InserirAcesso([FromBody]AcessoTable Acesso)
        {
            return _acessoService.InserirAcesso(Acesso);
        }

        [HttpPost]
        [Route("AlterarAcesso")]
        public bool AlterarAcesso([FromBody]AcessoTable Acesso)
        {
            return _acessoService.AlterarAcesso(Acesso);
        }

        [HttpDelete]
        [Route("AlterarAcesso")]
        public bool ExcluirAcesso(int idAcesso)
        {
            return _acessoService.ExcluirAcesso(idAcesso);
        }
    }
}
