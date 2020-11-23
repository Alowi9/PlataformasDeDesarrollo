﻿using ClassLibrary1.Entidades;
using Microsoft.AspNetCore.Mvc;
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


    }
}