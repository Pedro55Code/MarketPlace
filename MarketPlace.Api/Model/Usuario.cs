using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Model
{
    public class Usuario
    {
        [Key]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string SobreNome { get; set; }
        public char Sexo { get; set; }
        public string CPF { get; set; }
        public DateTime? DataNascimento { get; set; }
        public DateTime? DataHoraExclusao { get; set; }
        public Acesso Acesso { get; set; }
    }
}
