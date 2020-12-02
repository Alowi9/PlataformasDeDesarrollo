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

    public class UsuariosController : ControllerBase
    {

        private readonly Data.dataContext _context;


        public UsuariosController(Data.dataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Usuarios> Get()
        {
            return _context.Usuarios.ToList();
        }

        [HttpGet("{id}")]
        public Usuarios Getu(int id)
        {
            return _context.Usuarios.Where(i => i.id == id).Single();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Borrar = await _context.Usuarios.FindAsync(id);
            if (Borrar == null)
            {
                return NotFound();
            }

            _context.Usuarios.Remove(Borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }


        [HttpPost]

        public Usuarios Post(Usuarios valor)
        {
            var local = _context.Usuarios.Local.FirstOrDefault(e => e.id.Equals(valor.id));

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





    }
}
