using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {

            //armar un programa que dado una lista de numeros filtre los pares y los ordene de mayor a menor
/*
            List<int> numeros = new List<int> { 10, 2, 3, 4, 5, 6, 7, 8, 9 };

            for (var index = numeros.Count - 1; index >= 0; index--)
            {
                if (numeros[index] % 2 == 1)
                {
                    numeros.RemoveAt(index);
                }
            }


            numeros.Sort();
            numeros.Reverse();

            numeros.ForEach(
                number => Console.Write(number + " "));

            Sin linq 

            */

             
            /*  Con linq */

            List<int> listaDeNumeros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            var numerosPar = listaDeNumeros.Where(n => n % 2 == 0).OrderByDescending(n => n);
            foreach (var n in numerosPar)
            {
                Console.WriteLine(n);
            }



        }
    }
}
