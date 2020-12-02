using Microsoft.EntityFrameworkCore;
using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {
        public List<Tareas> getTareas()
        {
            var ctx = new dbContext();
            var lista = ctx.Tareas.ToList();
            return lista;

        }

        private dbContext context;

        public TareasService(dbContext _context)
        {
            context = _context;
        }

        public async Task<Tareas> Get(int id)
        {
            //return await context.Tareas.Where(i => i.id == id).SingleAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetTarea(id);
        }

        
        

        public async Task<List<Tareas>> GetAll()
        {
            // return await context.Tareas.Include(i => i.responsable).ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllTarea();

        }

        public async Task<Tareas> Save(Tareas value)
        {
            /*
            if (value.id == 0)
            {
                await context.Tareas.AddAsync(value);
            }
            else
            {
                context.Tareas.Update(value);
            }
            await context.SaveChangesAsync();

            return value;*/
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GuardarTareas(value);


        }

      /*  public async Task<bool> Remove(int id)
        {

            var entidad = await context.Tareas.Where(i => i.id == id).SingleAsync();
            context.Tareas.Remove(entidad);
            await context.SaveChangesAsync();
            return true;

        }
*/

        public async Task<Tareas> Remove(int id)
        {

            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");

            return await remoteService.BorrarTarea(id);


        }



        public async Task<List<Recursos>> GetRecursos()
        {
            // return await context.Recursos.ToListAsync();
            var remoteService = RestService.For<RemoteService>("https://localhost:44357/api/");
            return await remoteService.GetAllRecurso();

        }




    }
}
