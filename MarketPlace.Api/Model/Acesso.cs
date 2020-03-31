using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Model
{
    public class Acesso
    {
        public int Id{ get; set; }
        public int IdUsuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
