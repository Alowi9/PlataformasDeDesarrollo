using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    public abstract class CalculadoraBase
    {

        private int indice { get; set; }

        public virtual int Restar(int valor1, int valor2)
        {
            return valor1 - valor2;
        }

        public abstract int Division(int valor1, int valor2);
            
    }
}
