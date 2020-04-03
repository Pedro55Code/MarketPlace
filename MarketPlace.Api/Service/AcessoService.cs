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

        public bool InserirAcesso(AcessoTable Acesso)
        {
            try
            {
                _context.Acesso.Add(Acesso);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public AcessoTable ObterAcesso(int id)
        {
            try
            {
                return _context.Acesso
                    .AsNoTracking()
                    .Where(w => w.IdAcesso == id)
                    //.ProjectTo<Acesso>(_mapper.ConfigurationProvider)
                    .FirstOrDefault();
            }
            catch (Exception e)
            {
                return null;
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

        public bool ExcluirAcesso(int idAcesso)
        {
            try
            {
                _context.Remove(new AcessoTable { IdAcesso = idAcesso });
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
