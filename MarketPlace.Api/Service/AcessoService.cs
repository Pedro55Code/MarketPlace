using AutoMapper;
using AutoMapper.QueryableExtensions;
using MarketPlace.Api.DataBase;
using MarketPlace.Api.Interface;
using MarketPlace.Api.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MarketPlace.Api.Service
{
    public class AcessoService : IAcessoService
    {
        private readonly MarketPlaceContext _context;
        private readonly IMapper _mapper;

        public AcessoService(
            MarketPlaceContext context,
            IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public bool ValidarAcesso(string email, string senha)
        {
            try
            {
                var valida = _context.Acesso
                    .AsNoTracking()
                    .Where(w => w.Email == email && w.Senha == senha)
                    .FirstOrDefault();

                return valida == null ? false : true ;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public bool AlterarAcesso(AcessoTable Acesso)
        {
            try
            {
                _context.Entry(Acesso).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
    }
}
