using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Usuarios
    {
        public String nombre { get; set; }
        public String clave { get; set; }

        public Usuarios(string nombre, string clave)
        {
            this.nombre = nombre;
            this.clave = clave;
        }


        //sobreescribo el metodo toString para mostrar los datos de mi objeto 
        public override string ToString()
        {
            return  "Nombre: " + nombre.ToString();
        }

    }
}
