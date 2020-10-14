using System;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class TareasService
    {
        public Tareas[] GetTareas()
        {
            Tareas[] resultado = new Tareas[5];

            resultado[0] = new Tareas(1, "Tarea1", "30/06/2020", "10", false);
            resultado[1] = new Tareas(2, "Tarea2", "30/07/2020", "11", false);
            resultado[2] = new Tareas(3, "Tarea3", "30/08/2020", "12", false);
            resultado[3] = new Tareas(4, "Tarea4", "30/09/2020", "13", false);
            resultado[4] = new Tareas(5, "Tarea5", "30/10/2020", "14", false);


            return resultado;
        }
    }
}
