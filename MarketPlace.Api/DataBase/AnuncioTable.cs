using MarketPlace.Api.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class AnuncioTable
    {
        public int IdAnuncio { get; set; }
        public ECategoriaAnuncio IdCategoria { get; set; }
        public UsuarioTable IdUsuario { get; set; }
        public EnderecoTable IdEndereco { get; set; }
        public string Descricao { get; set; }
        public float Valor { get; set; } // ou decimal?
        public int Quantidade { get; set; }
        public DateTime DataCriacao { get; set; }
        public DateTime Registro_Exclusao{ get; set; }
    }
}
