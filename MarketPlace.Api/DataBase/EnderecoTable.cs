using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class EnderecoTable
    {
        [Key]
        [ForeignKey("Usuario")]
        public int Id { get; set; }
        public int IdUsuario { get; set; }
        public UsuarioTable Usuario { get; set; }
        public int IdBairro { get; set; }
        //public BairroTable Bairro { get; set; }
        public string Logradouro { get; set; }
        public int Numero { get; set; }
        public int Cep { get; set; }
    }
}
