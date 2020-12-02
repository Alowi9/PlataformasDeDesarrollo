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

    public class DetallesController : ControllerBase
    {
        private readonly Data.dataContext _context;


        public DetallesController(Data.dataContext context) {
            _context = context;
        }


        [HttpGet]

        public List<Detalles> Get()
        {
            return _context.Detalles.ToList();
        }

        [HttpGet("{id}")]
        public Detalles Get(int id)
        {
            return _context.Detalles.Where(i => i.id == id).Single();
        }


        [HttpPost]

        public Detalles Post(Detalles valor)
        {
            var local = _context.Detalles.Local.FirstOrDefault(e => e.id.Equals(valor.id));

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


        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            var Borrar = await _context.Detalles.FindAsync(id);
            if (Borrar == null)
            {
                return NotFound();
            }

            _context.Detalles.Remove(Borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }




    }
}
