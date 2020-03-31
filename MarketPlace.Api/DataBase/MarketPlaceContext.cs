using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class MarketPlaceContext : DbContext
    {
        public MarketPlaceContext(DbContextOptions<MarketPlaceContext> options) : base(options)
        {
        }

        public virtual DbSet<UsuarioTable> Usuario{ get; set; }
        public virtual DbSet<AcessoTable> Acesso{ get; set; }
    }
}
