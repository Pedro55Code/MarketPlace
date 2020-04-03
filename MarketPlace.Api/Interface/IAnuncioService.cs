using MarketPlace.Api.DataBase;
using MarketPlace.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Interface
{
    public interface IAnuncioService
    {
        List<AnuncioTable> ObterAnuncios(FiltroBuscaModel filtro);
    }
}
