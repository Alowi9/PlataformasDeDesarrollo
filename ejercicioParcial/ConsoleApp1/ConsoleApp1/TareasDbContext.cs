using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class TareasDbContext : DbContext
    {

        protected override void OnConfiguring (DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlite("Data Source=tareas.db");

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuarios>().ToTable("Usuario");
            modelBuilder.Entity<Tareas>().ToTable("Tarea");
            modelBuilder.Entity<Recursos>().ToTable("Recurso");
            modelBuilder.Entity<Detalles>().ToTable("Detalle");


        }

        public DbSet<Usuarios> Usuarios { get; set; }
        public DbSet<Tareas> Tareas { get; set; }
        public DbSet<Recursos> Recursos { get; set; }
        public DbSet<Detalles> Detalles { get; set; }


    }

}
