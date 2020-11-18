﻿

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Entidades
{
    public class Recursos
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }

        public int Userid { get; set; }
        public Usuarios User { get; set; }


        public Recursos() { }   //constructor implicito 


        public Recursos(int id, string nombre,int IdUsuario, Usuarios usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.Userid = IdUsuario;
            this.User = usuario;
        }


       

    }
}
