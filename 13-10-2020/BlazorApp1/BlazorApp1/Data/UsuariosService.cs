using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Refit;

namespace BlazorApp1.Data
{
    public class UsuariosService
    {
        private dbContext context;

        public List<Usuarios> getUsuarios()
        {
            var ctx = new dbContext();
            var lista = ctx.Usuarios.ToList();

            return lista;

        }

        

        public UsuariosService(dbContext _context)
        {
            context = _context;
        }

        public async Task<Usuarios> Get(int id)
        {
            // return await context.Usuarios.Where(i => i.id == id).SingleAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetUsuario(id);
        }



        

        public async Task<List<Usuarios>> GetAll()
        {
            // return await context.Usuarios.ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllUsuario();

        }

        public async Task<Usuarios> GuardarUsuario(Usuarios value)
        {
            // return await context.Usuarios.ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarUsuario(value);

        }


        public List<Usuarios> GetAllUsuario()
        {
            
            return  context.Usuarios.ToList();
        }

        public async Task<Usuarios> Save(Usuarios value)
        {
            /*
            if (value.id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            */
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarUsuario(value);
            //return value;
        }

      


        public async Task<Usuarios> Remove(int id )
        {
            /*
             var entidad = await context.Usuarios.Where(i => i.id == id).SingleAsync();
             context.Usuarios.Remove(entidad);
             await context.SaveChangesAsync();
            */
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            
            return await remoteService.BorrarUsuario(id);
             

        }






    }
}
