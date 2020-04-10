using MarketPlace.Api.Mapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class MarketPlaceContext : DbContext
    {
        public virtual DbSet<UsuarioTable> Usuario{ get; set; }
        public virtual DbSet<AcessoTable> Acesso{ get; set; }
        public virtual DbSet<EnderecoTable> Endereco{ get; set; }
        public virtual DbSet<EstadoTable> Estado { get; set; }
        public virtual DbSet<CidadeTable> Cidade { get; set; }
        public virtual DbSet<BairroTable> Bairro { get; set; }

        public MarketPlaceContext(DbContextOptions<MarketPlaceContext> options) : base(options)
        {
        }

        protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioTable>().Property(p => p.Id).UseIdentityColumn();
            modelBuilder.Entity<UsuarioTable>().HasOne(h => h.Endereco).WithOne(h => h.Usuario).HasForeignKey<EnderecoTable>(f => f.IdUsuario);
            modelBuilder.Entity<UsuarioTable>().HasOne(h => h.Acesso).WithOne(h => h.Usuario).HasForeignKey<AcessoTable>(f => f.IdUsuario);

            
            //modelBuilder.Entity<UsuarioTable>()
            //   .HasOptional(s => s.Endereco) // Mark Address property optional in Student entity
            //   .WithRequired(ad => ad.Usuario);
            //modelBuilder.Configurations.Add(new UsuarioMap());
            //modelBuilder.Configurations.Add(new EnderecoMap());
            //modelBuilder.Configurations.Add(new EstadoMap());
            //modelBuilder.Configurations.Add(new CidadeMap());
            //modelBuilder.Configurations.Add(new BairroMap());
            //modelBuilder.Configurations.Add(new EnderecoMap());

            //modelBuilder.Entity<UsuarioTable>().HasKey(t => t.Id);
            //modelBuilder.Entity<UsuarioTable>().HasOne(t => t.Endereco);

            //modelBuilder.Entity<EnderecoTable>().HasKey(t => t.Id);
            //modelBuilder.Entity<EnderecoTable>().HasOne(t => t.Usuario).WithOne(t => t.Endereco).HasForeignKey<EnderecoTable>(t => t.IdUsuario).IsRequired();



        }
    }
}
