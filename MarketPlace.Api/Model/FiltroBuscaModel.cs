using MarketPlace.Api.DataBase;
using MarketPlace.Api.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Model
{
    public class FiltroBuscaModel
    {
        public ECategoriaAnuncio Categoria { get; set; }
        public string Descricao { get; set; }
        public EstadoTable Estado { get; set; }
        public CidadeTable Cidade { get; set; }
        public BairroTable? Bairro { get; set; }
    }
}
