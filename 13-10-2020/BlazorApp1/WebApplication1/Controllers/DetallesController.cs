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


    }
}
