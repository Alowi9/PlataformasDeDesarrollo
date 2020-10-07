using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class Detalles
    {
        [Key]
        public int id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }

        public int IdRecurso { get; set; }
        public Recursos Recurso { get; set; }
        
        public int IdTarea { get; set; }
        public Tareas Tarea { get; set; }

    }
}
