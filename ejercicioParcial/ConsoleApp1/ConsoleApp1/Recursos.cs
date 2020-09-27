using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Recursos
    {
        public String nombre { get; set; }
        public Usuarios usuario { get; set; }

        public Recursos(string nombre, Usuarios usuario)
        {
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
