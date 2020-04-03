using MarketPlace.Api.DataBase;
using MarketPlace.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Threading.Tasks;

namespace MarketPlace.Api.Interface
{
    public interface IUsuarioService
    {
        UsuarioTable ObterUsuario(int id);
        bool InserirUsuario(UsuarioTable usuario);
        bool InserirEnderecoUsuario(EnderecoTable endereco);
        bool AlterarUsuario(UsuarioTable usuario);
        bool ExcluirUsuario(int idUsuario);
    }
}
