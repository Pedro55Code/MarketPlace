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

                var endereco = usuario.Endereco;

                var acesso = usuario.Acesso;
                
                _context.SaveChanges();

                var idUsuario = usuario.Id;

                endereco.IdUsuario = idUsuario;

                acesso.IdUsuario = idUsuario;

                _context.Entry(endereco).State = EntityState.Modified;
                _context.Entry(acesso).State = EntityState.Modified;

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
                var usuario = _context.Usuario.AsNoTracking().Where(w => w.Id == idUsuario).FirstOrDefault();

                usuario.Registro_Exclusao = DateTime.Now;

                _context.Entry(usuario).State = EntityState.Modified;

                _context.SaveChanges();

                return true;
            } catch(Exception e)
            {
                return false;
            }
        }
    }
}
