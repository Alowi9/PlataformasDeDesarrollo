using ClassLibrary1.Entidades;

using Microsoft.AspNetCore.Mvc;
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
            if (valor.id == 0)
            {
                _context.Detalles.Add(valor);
            }
            else
            {
                _context.Detalles.Attach(valor);
                _context.Detalles.Update(valor);
            }

            _context.SaveChanges();
            return valor;
        }



    }
}
