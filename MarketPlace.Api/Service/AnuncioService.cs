using AutoMapper;
using MarketPlace.Api.DataBase;
using MarketPlace.Api.Interface;
using MarketPlace.Api.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Service
{
    public class AnuncioService : IAnuncioService
    {
        private readonly MarketPlaceContext _context;
        private readonly IMapper _mapper;

        public AnuncioService(
            MarketPlaceContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public List<AnuncioTable> ObterAnuncios(FiltroBuscaModel filtro)
        {
            return new List<AnuncioTable>();
        }
    }
}
