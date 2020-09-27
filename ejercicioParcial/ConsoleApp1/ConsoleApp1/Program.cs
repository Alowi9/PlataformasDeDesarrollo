using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Usuarios u1 = new Usuarios("Maximiliano","123asd");
            Recursos r1 = new Recursos("RecursoUno",u1);

            List<Tareas> tareas = new List<Tareas>();

            tareas.Add(new Tareas("Tarea1", "30/06/2020", "10", r1, false)); ;
            tareas.Add(new Tareas("Tarea2", "30/07/2020", "11", r1, false)); ;
            tareas.Add(new Tareas("Tarea3", "30/08/2020", "12", r1, false)); ;
            tareas.Add(new Tareas("Tarea4", "30/09/2020", "13", r1, false)); ;
            tareas.Add(new Tareas("Tarea5", "30/10/2020", "14", r1, false)); ;



            // hago un for para recorrer mi lista de tareas y mostrar en consola 
            for (int i=0; i<tareas.Count; i++)
            {
                Console.WriteLine( tareas[i] );
                Console.WriteLine("");
            }


             
           // Console.WriteLine(u1);   ---- > esto es de prueba para mostrar los datos del objeto usuario 



        }
    }
}
