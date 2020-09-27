using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tareas
    {
        public String titulo { get; set; }
        public String vencimiento { get; set; }
        public String estimacion { get; set; }
        public Recursos responsable { get; set; }
        public bool estado { get; set; }

        public Tareas(string titulo, string vencimiento, string estimacion, Recursos responsable, bool estado)
        {
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
