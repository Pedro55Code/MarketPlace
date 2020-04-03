using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.DataBase
{
    public class EstadoTable
    {
        [Key]
        public int IdEstado { get; set; }
        public string NomeEstado { get; set; }
        //public List<CidadeTable>? Cidade { get; set; }
    }
    
    public class CidadeTable
    {
        [Key]
        public int IdCidade { get; set; }
        public EstadoTable Estado { get; set; }
        public string NomeCidade { get; set; }
        //public List<BairroTable>? Bairro { get; set; }
    }
    
    public class BairroTable
    {
        [Key]
        public int IdBairro { get; set; }
        public CidadeTable Cidade { get; set; }
        public string NomeBairro { get; set; }
        //public List<EnderecoTable>? Endereco { get; set; }
    }
}
