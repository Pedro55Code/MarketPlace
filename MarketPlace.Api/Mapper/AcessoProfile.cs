using MarketPlace.Api.DataBase;
using MarketPlace.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Mapper
{
    public class AcessoProfile : AutoMapper.Profile
    {
        public AcessoProfile()
        {
            CreateMap<AcessoTable, Acesso>();
        }
    }
}
