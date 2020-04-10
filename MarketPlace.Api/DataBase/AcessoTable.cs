﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class AcessoTable
    {
        [ForeignKey("Usuario")]
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public int? IdUsuario { get; set; }
        public UsuarioTable? Usuario { get; set; }
        public string Email { get; set; }
        public string Senha { get; set; }
    }
}
