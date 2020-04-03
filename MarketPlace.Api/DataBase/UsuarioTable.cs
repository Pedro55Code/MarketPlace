using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class UsuarioTable
    {
        [Key]
        public int Id { get; set; }
        public string Nome { get; set; }
        public char Sexo { get; set; }
        public string CPF { get; set; }
        public DateTime? Nascimento { get; set; }
        public DateTime? Registro_Exclusao { get; set; }
        //public AcessoTable Acesso { get; set; }
        public EnderecoTable Endereco { get; set; }
    }
}
