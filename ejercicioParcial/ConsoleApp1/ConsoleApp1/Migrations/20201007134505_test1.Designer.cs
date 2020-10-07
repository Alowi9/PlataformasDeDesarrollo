﻿// <auto-generated />
using System;
using ConsoleApp1;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ConsoleApp1.Migrations
{
    [DbContext(typeof(TareasDbContext))]
    [Migration("20201007134505_test1")]
    partial class test1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.8");

            modelBuilder.Entity("ConsoleApp1.Detalles", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Fecha")
                        .HasColumnType("TEXT");

                    b.Property<int>("IdRecurso")
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdTarea")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Recursoid")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("Tareaid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Tiempo")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("Recursoid");

                    b.HasIndex("Tareaid");

                    b.ToTable("Detalle");
                });

            modelBuilder.Entity("ConsoleApp1.Recursos", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdUsuario")
                        .HasColumnType("INTEGER");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT");

                    b.Property<int?>("usuarioid")
                        .HasColumnType("INTEGER");

                    b.HasKey("id");

                    b.HasIndex("usuarioid");

                    b.ToTable("Recurso");
                });

            modelBuilder.Entity("ConsoleApp1.Tareas", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("IdRecursos")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("estado")
                        .HasColumnType("INTEGER");

                    b.Property<string>("estimacion")
                        .HasColumnType("TEXT");

                    b.Property<int?>("responsableid")
                        .HasColumnType("INTEGER");

                    b.Property<string>("titulo")
                        .HasColumnType("TEXT");

                    b.Property<string>("vencimiento")
                        .HasColumnType("TEXT");

                    b.HasKey("id");

                    b.HasIndex("responsableid");

                    b.ToTable("Tarea");
                });

            modelBuilder.Entity("ConsoleApp1.Usuarios", b =>
                {
                    b.Property<int>("id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("clave")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("nombre")
                        .HasColumnType("TEXT")
                        .HasMaxLength(50);

                    b.HasKey("id");

                    b.ToTable("Usuario");
                });

            modelBuilder.Entity("ConsoleApp1.Detalles", b =>
                {
                    b.HasOne("ConsoleApp1.Recursos", "Recurso")
                        .WithMany()
                        .HasForeignKey("Recursoid");

                    b.HasOne("ConsoleApp1.Tareas", "Tarea")
                        .WithMany()
                        .HasForeignKey("Tareaid");
                });

            modelBuilder.Entity("ConsoleApp1.Recursos", b =>
                {
                    b.HasOne("ConsoleApp1.Usuarios", "usuario")
                        .WithMany()
                        .HasForeignKey("usuarioid");
                });

            modelBuilder.Entity("ConsoleApp1.Tareas", b =>
                {
                    b.HasOne("ConsoleApp1.Recursos", "responsable")
                        .WithMany()
                        .HasForeignKey("responsableid");
                });
#pragma warning restore 612, 618
        }
    }
}
