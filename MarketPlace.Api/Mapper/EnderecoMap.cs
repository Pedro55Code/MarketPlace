using MarketPlace.Api.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Mapper
{
    public class EnderecoMap : EntityTypeConfiguration<EnderecoTable>
    {
        public void Configure(EntityTypeBuilder<EnderecoTable> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            builder.Property(x => x.Usuario.Id).HasColumnName("IdUsuario");
            builder.HasKey(x => x.Usuario.Id);
            //builder.Property(x => x.IdBairro);
            //builder.HasKey(x => x.IdBairro);
            builder.Property(x => x.Logradouro).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Numero).IsRequired();
            builder.Property(x => x.Cep).IsRequired();
            
            //builder.HasOne(h => h.Usuario).WithOne(w => w.Endereco).HasForeignKey<UsuarioTable>(f => new { f.IdUsuario});

            //HasOptional(r => r.Usuario).WithRequired(r => r.Endereco);
        }

        //public EnderecoMap()
        //{
        //    ToTable("Endereco");

        //    HasKey(x => x.IdEndereco).Property(x => x.IdEndereco).HasColumnName("IdEndereco").IsRequired()
        //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        //    Property(x => x.Logradouro).HasColumnName("Logradouro").IsRequired().HasMaxLength(50);
        //    Property(x => x.Numero).HasColumnName("Numero").IsRequired();
        //    Property(x => x.Cep).HasColumnName("Cep").IsRequired();

        //    HasRequired(x => x.Usuario).WithOptional(x => x.Endereco);

        //    HasRequired(x => x.Bairro).WithMany(x => x.Endereco).HasForeignKey(f => f.IdBairro);
        //}
    }
}
