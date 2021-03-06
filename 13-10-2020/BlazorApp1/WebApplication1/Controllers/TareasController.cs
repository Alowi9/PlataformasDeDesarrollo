﻿using ClassLibrary1.Entidades;
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

    public class TareasController : ControllerBase
    {

        private readonly Data.dataContext _context;


        public TareasController(Data.dataContext context)
        {
            _context = context;
        }


        [HttpGet]

        public List<Tareas> Get()
        {
            return _context.Tareas.Include(i => i.responsable).ToList();
        }

        [HttpGet("{id}")]
        public Tareas Get(int id)
        {
            return _context.Tareas.Where(i => i.id == id).Single();
        }



        [HttpPost]

        public Tareas Post(Tareas valor)
        {
            var local = _context.Tareas.Local.FirstOrDefault(e => e.id.Equals(valor.id));

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
            var Borrar = await _context.Tareas.FindAsync(id);
            if (Borrar == null)
            {
                return NotFound();
            }

            _context.Tareas.Remove(Borrar);
            await _context.SaveChangesAsync();

            return NoContent();
        }




    }
}
