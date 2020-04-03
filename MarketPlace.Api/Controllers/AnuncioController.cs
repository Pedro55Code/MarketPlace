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
    public class AnuncioController : Controller
    {
        private readonly IAnuncioService _anuncioService;

        public AnuncioController(IAnuncioService anuncioService)
        {
            _anuncioService = anuncioService;
        }

        [HttpGet]
        [Route("ObterAnuncios")]
        public List<AnuncioTable> ObterAnuncios(FiltroBuscaModel filtro) 
        {
            return _anuncioService.ObterAnuncios(filtro);
        }

        //[HttpPost]
        //[Route("InserirAcesso")]
        //public bool InserirAcesso([FromBody]AcessoTable Acesso)
        //{
        //    return _acessoService.InserirAcesso(Acesso);
        //}

        //[HttpPost]
        //[Route("AlterarAcesso")]
        //public bool AlterarAcesso([FromBody]AcessoTable Acesso)
        //{
        //    return _acessoService.AlterarAcesso(Acesso);
        //}

        //[HttpDelete]
        //[Route("AlterarAcesso")]
        //public bool ExcluirAcesso(int idAcesso)
        //{
        //    return _acessoService.ExcluirAcesso(idAcesso);
        //}
    }
}
