using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Class1 clase = new Class1();

            calculadora.SetNumero1(13);
            Console.WriteLine(calculadora.GetNumero1());

            calculadora.Numero1 = 105;
            Console.WriteLine(calculadora.Numero1);

            calculadora.Numero2 = 20;
            Console.WriteLine(calculadora.Numero2);
        }
    }
}
