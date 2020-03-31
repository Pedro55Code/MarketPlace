using MarketPlace.Api.DataBase;
using MarketPlace.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Interface
{
    public interface IAcessoService
    {
        Acesso ObterAcesso(int id);
        bool InserirAcesso(AcessoTable acesso);
        bool AlterarAcesso(AcessoTable acesso);
        bool ExcluirAcesso(int idAcesso);
    }
}
