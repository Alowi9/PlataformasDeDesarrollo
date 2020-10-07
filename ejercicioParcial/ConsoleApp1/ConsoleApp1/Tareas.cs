using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ConsoleApp1
{
    public class Tareas
    {
        [Key]    
        public int id { get; set; }
        public String titulo { get; set; }
        public String vencimiento { get; set; }
        public String estimacion { get; set; }
        public int IdRecursos { get; set; } 
    public Recursos responsable { get; set; }
        public bool estado { get; set; }


        public Tareas()  { }   //constructor implicito 

        public Tareas(int id, string titulo, string vencimiento, string estimacion, Recursos responsable, bool estado)
        {
            this.id = id;
            this.titulo = titulo;
            this.vencimiento = vencimiento;
            this.estimacion = estimacion;
            this.responsable = responsable;
            this.estado = estado;
        }


        //sobreescribo el metodo toString para mostrar los datos de mi objeto 
        public override string ToString()
        {
            return "Titulo: " + titulo.ToString() + "\n Vencimiento: " + vencimiento.ToString() + "\n Estimacion: " + estimacion.ToString() + "\n responsable: " + responsable + "\n Estado: " + estado.ToString();
        }


    }
}
