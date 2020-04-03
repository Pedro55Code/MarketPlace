using MarketPlace.Api.DataBase;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Mapper
{
    public class UsuarioMap : EntityTypeConfiguration<UsuarioTable>
    {
        public void Configure(EntityTypeBuilder<UsuarioTable> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd();
            //.HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            builder.Property(x => x.Nome).IsRequired().HasMaxLength(50);
            builder.Property(x => x.CPF).IsRequired().HasMaxLength(50);
            builder.Property(x => x.Nascimento).IsRequired();
            builder.Property(x => x.Sexo).IsRequired();
            builder.Property(x => x.Registro_Exclusao).IsRequired();

            //builder.HasOne(h => h.Endereco).WithOne(w => w.Usuario).HasForeignKey<UsuarioTable>(f => new { f.IdUsuario });
            
            //HasOptional(r => r.Endereco).WithRequired(r => r.Usuario);
        }

        //public UsuarioMap() 
        //{
        //    ToTable("Usuario");

        //    HasKey(x => x.IdUsuario).Property(x => x.IdUsuario).HasColumnName("IdUsuario").IsRequired()
        //        .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

        //    Property(x => x.Nome).HasColumnName("Nome").IsRequired().HasMaxLength(50);
        //    Property(x => x.CPF).HasColumnName("CPF").IsRequired().HasMaxLength(50);
        //    Property(x => x.Nascimento).HasColumnName("Nascimento").IsRequired();
        //    Property(x => x.Sexo).HasColumnName("Sexo").IsRequired();
        //    Property(x => x.Registro_Exclusao).HasColumnName("Registro_Exclusao").IsRequired();
            
            

        //    HasOptional(r => r.Endereco).WithRequired(r => r.Usuario);
        //}
    }
}
