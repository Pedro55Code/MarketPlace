using MarketPlace.Api.DataBase;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Mapper
{
    public class BairroMap : EntityTypeConfiguration<BairroTable>
    {
        public BairroMap()
        {
            ToTable("Bairro");

            HasKey(x => x.IdBairro).Property(x => x.IdBairro).HasColumnName("IdBairro").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeBairro).HasColumnName("NomeBairro").IsRequired().HasMaxLength(50);
            
            //HasRequired(x => x.Cidade).WithMany(x => x.Bairro).HasForeignKey(f => f.Cidade);
            //HasMany(x => x.Endereco).WithRequired(r => r.Bairro).HasForeignKey(f => f.IdBairro);
        }
    }

    public class CidadeMap : EntityTypeConfiguration<CidadeTable>
    {
        public CidadeMap()
        {
            ToTable("Cidade");

            HasKey(x => x.IdCidade).Property(x => x.IdCidade).HasColumnName("IdCidade").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeCidade).HasColumnName("NomeCidade").IsRequired().HasMaxLength(50);

            //HasRequired(x => x.Estado).WithMany(x => x.Cidade);
            // HasMany(x => x.Bairro).WithRequired(x => x.Cidade).HasForeignKey(f => f.Cidade);
        }
    }

    public class EstadoMap : EntityTypeConfiguration<EstadoTable>
    {
        public EstadoMap()
        {
            ToTable("Estado");

            HasKey(x => x.IdEstado).Property(x => x.IdEstado).HasColumnName("IdEstado").IsRequired()
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.NomeEstado).HasColumnName("NomeEstado").IsRequired().HasMaxLength(50);

            //HasMany(h => h.Cidade).WithRequired(h => h.Estado).HasForeignKey(f => f.Estado);
        }
    }
}
