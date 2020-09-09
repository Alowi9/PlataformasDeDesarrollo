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

            CalculadoraCientifica cc1 = new CalculadoraCientifica();


            /*
            calculadora.SetNumero1(13);
            Console.WriteLine(calculadora.GetNumero1());

            calculadora.Numero1 = 105;
            Console.WriteLine(calculadora.Numero1);

            calculadora.Numero2 = 20;
            Console.WriteLine(calculadora.Numero2);
            */

           calculadora.Numero2 = 0;
            int num2 = calculadora.Numero2;
           calculadora.Numero1 = 3;
            int num1 = calculadora.Numero1;
            Console.WriteLine(calculadora.Numero1);
            Console.WriteLine(calculadora.Numero2);
            Console.WriteLine("---------");

            Console.WriteLine (calculadora.Sumar(num1, num2) );
            Console.WriteLine (calculadora.Restar(num1, num2));
            Console.WriteLine (calculadora.Multiplicar (num1, num2));
            Console.WriteLine (calculadora.Dividir(num1, num2));
            Console.WriteLine("---------");

            /*--------------------------------------------------------------*/

            Console.WriteLine(calculadora.Sumar(2,5) );
            Console.WriteLine(calculadora.Restar(5, 5));
            Console.WriteLine(calculadora.Multiplicar(1, 10));
            Console.WriteLine(calculadora.Dividir(10, 5));
            Console.WriteLine("---------");


            Console.WriteLine(cc1.Potencia(2, 3));



        }
    }
}
