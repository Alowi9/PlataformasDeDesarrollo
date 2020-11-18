
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ClassLibrary1.Entidades
{
    public class Tareas
    {
        [Key]
        public int id { get; set; }
        public String titulo { get; set; }
        public String vencimiento { get; set; }
        public String estimacion { get; set; }
        public int responsableid { get; set; }
        public Recursos responsable { get; set; }
        public bool estado { get; set; }


        public Tareas() { }   //constructor implicito 

        public Tareas(int id, string titulo, string vencimiento, string estimacion,int IdRecursos, Recursos responsable, bool estado)
        {
            this.id = id;
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsableid = IdRecursos;
            this.responsable = responsable;
            this.estado = estado;
        }

        //recordar incoorporar la clase Recursos más tarde!
        


    }
}
