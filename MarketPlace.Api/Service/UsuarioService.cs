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
    public class UsuarioService : IUsuarioService
    {
        private readonly MarketPlaceContext _context;
        private readonly IMapper _mapper;

        public UsuarioService(
            MarketPlaceContext context,
            IMapper mapper) 
        {
            _context = context;
            _mapper = mapper;
        }

        public bool InserirUsuario(UsuarioTable usuario)
        {
            try
            {
                _context.Usuario.Add(usuario);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }
        
        public bool InserirEnderecoUsuario(EnderecoTable endereco)
        {
            try
            {
                _context.Endereco.Add(endereco);
                _context.SaveChanges();
                return true;
            }
            catch (Exception e)
            {
                return false;
            }
        }

        public UsuarioTable ObterUsuario(int id)
        {
            try
            {
                var e = _context.Endereco.Include(b => b.Usuario)
                    .AsNoTracking()
                    .First();

                var a = _context.Usuario.Include(b => b.Endereco)
                    .AsNoTracking()
                    .Where(w => w.Id == id)
                    //.ProjectTo<Usuario>(_mapper.ConfigurationProvider)
                    .FirstOrDefault();

                return a;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public bool AlterarUsuario(UsuarioTable usuario)
        {
            try
            {
                //_context.Usuario.FirstOrDefault(f => f.IdUsuario == usuario.IdUsuario);
                //_context.Usuario.Update(usuario);
                _context.Entry(usuario).State = EntityState.Modified;
                _context.SaveChanges();
                return true;
            } 
            catch(Exception e)
            {
                return false;
            }
        }

        public bool ExcluirUsuario(int idUsuario)
        {
            try
            {
                _context.Remove(new UsuarioTable { Id = idUsuario});
                _context.SaveChanges();

                return true;
            } catch(Exception e)
            {
                return false;
            }
        }
    }
}
