using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Calculadora
    {

        private int numero1;
        public int Numero1
        {
            get
            {
                return numero1;
            }
            set
            {
                numero1 = value;
            }

        }


        public int Numero2 { get; set; }
        // otra forma de escribirlo 
        // dentro del get o set se pueden cambiarla la visibilidad sea private, protected etc...


        public void SetNumero1(int valor)
        {
            numero1 = valor;
        }

        public int GetNumero1()
        {
            return numero1;
        }




        private class Operacion
        {

        }


    }
}
