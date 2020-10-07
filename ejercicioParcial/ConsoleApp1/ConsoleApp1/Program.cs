using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;

namespace ConsoleApp1
{
    public class Program
    {
        static void Main(string[] args)
        {
            /*
                        Usuarios u1 = new Usuarios(1,"Maximiliano","123asd");
                        Recursos r1 = new Recursos(1,"RecursoUno",u1);

                        List<Tareas> tareas = new List<Tareas>();

                        tareas.Add(new Tareas(1,"Tarea1", "30/06/2020", "10", r1, false)); ;
                        tareas.Add(new Tareas(2,"Tarea2", "30/07/2020", "11", r1, false)); ;
                        tareas.Add(new Tareas(3,"Tarea3", "30/08/2020", "12", r1, false)); ;
                        tareas.Add(new Tareas(4,"Tarea4", "30/09/2020", "13", r1, false)); ;
                        tareas.Add(new Tareas(5,"Tarea5", "30/10/2020", "14", r1, false)); ;

                        // hago un for para recorrer mi lista de tareas y mostrar en consola 
                        for (int i=0; i<tareas.Count; i++)
                        {
                            Console.WriteLine( tareas[i] );
                            Console.WriteLine("");
                        }

            */

            // Console.WriteLine(u1);   ---- > esto es de prueba para mostrar los datos del objeto usuario 
            /* ---------------------------------------------------------------------------------------------*/




            // InsertarUsuarios();   // agrego usuarios a la base de datos 
            // InsertarRecursos(); // agrego recursos a la base de datos
            // InsertarTareas();  // agrego recursos a la base de datos
            // InsertarDetalles(); //agrego detalles a la base de datos 


            // Borrado(); // aca se hardcodio un metodo donde borra un elemento de las tablas: Usuario, Tareas y Recursos

            // Actualizacion();   // aca se hardcodio un metodo donde modifica un elemento de las tablas: Usuario, Tareas y Recursos

            Consultar(); // aca consulto los datos de mi BD y los muestro por consola 

        }





        static void Borrado()
            {
                
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.id == 1).Single();
            ctx.Usuarios.Remove(usuario);


            var tarea = ctx.Tareas.Where(i => i.id == 2).Single();
            ctx.Tareas.Remove(tarea);

            var recurso = ctx.Recursos.Where(i => i.id == 3).Single();
            ctx.Recursos.Remove(recurso);

            ctx.SaveChanges();
            }


        static void Actualizacion()
            {
               
            var ctx = new TareasDbContext();
                
            var lista = ctx.Tareas.Where(i => i.id == 1).ToList();
                lista[0].titulo = "iLTareaa";
                


            var lista2 = ctx.Usuarios.Where(i => i.id == 3).ToList();
            lista2[0].nombre = "Josefina";

            var lista3 = ctx.Recursos.Where(i => i.id == 4).ToList();
            lista3[0].nombre = "RecursoReLoco";



            ctx.SaveChanges();

        }

        static void Consultar()
            {
                var ctx = new TareasDbContext();

                var lista = ctx.Usuarios.ToList();
                foreach (var item in lista)
                {
                    Console.WriteLine($"Usuario: {item.nombre} ({item.id})");
                }

            var lista2 = ctx.Tareas.ToList();
            foreach (var item in lista2)
            {
                Console.WriteLine($"Tarea: {item.titulo} ({item.id})");
            }


            var lista3 = ctx.Recursos.ToList();
            foreach (var item in lista3)
            {
                Console.WriteLine($"Recurso: {item.nombre} ({item.id})");
            }


        }




        /* ------------- ACA SOY LOS METODOS QUE AGREGAN PERSONAS A LA BASE DE DATOS ---------- */


        static void InsertarRecursos()
            {
                var ctx = new TareasDbContext();

            ctx.Recursos.Add(new Recursos
            {
                id = 2,
                nombre = "Recurso2",
              IdUsuario = 1
            }
                ); ;

            ctx.Recursos.Add(new Recursos
            {
                id = 3,
                nombre = "Recurso3",
                IdUsuario = 2
            }
           ); ;


            ctx.Recursos.Add(new Recursos
            {
                id = 4,
                nombre = "Recurso4",
                IdUsuario = 3
            }
           ); ;


            ctx.SaveChanges();
            }


        static void InsertarDetalles()
        {
            var ctx = new TareasDbContext();


            ctx.Detalles.Add(new Detalles{ 
             id = 1,
             Fecha = "16/11/1995",
             Tiempo = "2 meses",
             IdRecurso = 1,
             IdTarea = 1

            
            });


            ctx.Detalles.Add(new Detalles
            {
                id = 2,
                Fecha = "26/05/2001",
                Tiempo = "5 meses",
                IdRecurso = 2,
                IdTarea = 1


            });



            ctx.Detalles.Add(new Detalles
            {
                id = 3,
                Fecha = "18/05/1990",
                Tiempo = "12 meses",
                IdRecurso = 3,
                IdTarea = 3


            });




            ctx.SaveChanges();


        }



        static void InsertarTareas()
        {
            var ctx = new TareasDbContext();

            ctx.Tareas.Add(new Tareas{
            
                id = 2,
                titulo = "tarea2",
                vencimiento = "09/21",
                estimacion = "12/20",
                IdRecursos = 2,
                estado = false
            });

            ctx.Tareas.Add(new Tareas
            {

                id = 3,
                titulo = "tarea3",
                vencimiento = "11/22",
                estimacion = "05/21",
                IdRecursos = 2,
                estado = false
            });



            ctx.SaveChanges();

        }

        static void InsertarUsuarios()
        {
            var ctx = new TareasDbContext();

            ctx.Usuarios.Add(new Usuarios
            {
                id = 1,
                nombre = "Maximiliano",
                clave = "0303"
            }
              );


            ctx.Usuarios.Add(new Usuarios
            {
                id = 2,
                nombre = "Vladimir",
                clave = "1313"
            }
                   );


            ctx.Usuarios.Add(new Usuarios
            {
                id = 3,
                nombre = "David",
                clave = "0404"
            }
                );


            ctx.Usuarios.Add(new Usuarios
            {
                id = 4,
                nombre = "Daiana",
                clave = "0505"
            }
                );

            ctx.SaveChanges();

        }



    }
}
