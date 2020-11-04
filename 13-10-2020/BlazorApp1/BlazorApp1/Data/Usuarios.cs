using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BlazorApp1.Data
{

    [Table("Usuario")] // cambia el nombre de mi tabla
    public class Usuarios
    {
        [Key]
        public int id { get; set; }

        [MaxLength(50)]  // maximo de longitud de caracteres 
        [MinLength(3)]  // minimo de longitud de caracteres 
        public String nombre { get; set; }
        [Required] //que no acepta nulos
                   //  [Column("Password", TypeName = "char(20)")]

        public String clave { get; set; }



        public Usuarios() { }  //constructor implicito 

        public Usuarios(int id, string nombre, string clave)
        {
            this.id = id;
            this.nombre = nombre;
            this.clave = clave;
        }



    }
}
