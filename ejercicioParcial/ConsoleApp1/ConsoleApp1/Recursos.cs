using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
   public class Recursos
    {
        [Key]
        public int id { get; set; }
        public String nombre { get; set; }

        public int IdUsuario { get; set; }
        public Usuarios usuario { get; set; }
       
        
        public Recursos() { }   //constructor implicito 


        public Recursos(int id,string nombre, Usuarios usuario)
        {
            this.id = id;
            this.nombre = nombre;
            this.usuario = usuario;
        }


        //sobreescribo el metodo toString para mostrar los datos de mi objeto 
        public override string ToString()
        {
            return nombre.ToString() + "\n " + usuario.ToString();
        }

    }
}
