using ClassLibrary1.Entidades;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]

    public class RecursosController : ControllerBase
    {
       
        
        private readonly Data.dataContext _context;


        public RecursosController(Data.dataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Recursos> Get()
        {
            return _context.Recursos.Include(i => i.User).ToList();
        }

        [HttpGet("{id}")]
        public Recursos Get(int id)
        {
            return _context.Recursos.Where(i => i.id == id).Single();
        }



        [HttpPost]

        public Recursos Post(Recursos valor)
        {
            var local = _context.Recursos.Local.FirstOrDefault(e => e.id.Equals(valor.id));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }

            _context.SaveChanges();
            return valor;
        }



            /// Source: https://docs.microsoft.com/en-us/aspnet/core/tutorials/first-web-api?view=aspnetcore-5.0&tabs=visual-studio#the-deletetodoitem-method
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Borrar = await _context.Recursos.FindAsync(id);
            if (Borrar == null)
            {
                return NotFound();
            }

            _context.Recursos.Remove(Borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }




    }
}
