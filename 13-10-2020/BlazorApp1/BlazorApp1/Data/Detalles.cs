using BlazorApp1.Pages;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace BlazorApp1.Data
{
    public class Detalles
    {
        [Key]
        public int id { get; set; }
        public string Fecha { get; set; }
        public string Tiempo { get; set; }

        public int Recurid { get; set; }
        public Recursos Recur { get; set; }

        public int Tareaid { get; set; }
        public Tareas Tarea { get; set; }

        public Detalles() { }   //constructor implicito 


        public Detalles(int id, string fecha, string tiempo,int IdRecurso, Recursos recurso, int IdTarea, Tareas tarea)
        {
            this.id = id;
            this.Fecha = fecha;
            this.Tiempo = tiempo;
            this.Recurid = IdRecurso;
            this.Recur = recurso;
            this.Tareaid = IdTarea;
            this.Tarea = tarea;
        }


    }
}