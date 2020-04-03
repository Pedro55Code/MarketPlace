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
    public class UsuarioController : Controller
    {
        private readonly IUsuarioService _usuarioService;

        public UsuarioController(IUsuarioService usuarioService)
        {
            _usuarioService = usuarioService;
        }

        [HttpGet]
        [Route("ObterUsuario")]
        public UsuarioTable ObterUsuario(int id)
        {
            return _usuarioService.ObterUsuario(id);
        }

        [HttpPost]
        [Route("InserirUsuario")]
        public bool InserirUsuario([FromBody]UsuarioTable usuario)
        {
            return _usuarioService.InserirUsuario(usuario);
        }

        [HttpPost]
        [Route("InserirEnderecoUsuario")]
        public bool InserirEnderecoUsuario([FromBody]EnderecoTable endereco)
        {
            return _usuarioService.InserirEnderecoUsuario(endereco);
        }

        [HttpPost]
        [Route("AlterarUsuario")]
        public bool AlterarUsuario([FromBody]UsuarioTable usuario)
        {
            return _usuarioService.AlterarUsuario(usuario);
        }


        [HttpDelete]
        [Route("AlterarUsuario")]
        public bool ExcluirUsuario(int idUsuario)
        {
            return _usuarioService.ExcluirUsuario(idUsuario);
        }
    }
}
