﻿using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface RemoteService
    {

        [Get("/Tareas")]
        Task<List<Tareas>> GetAllTarea();

        [Post("/Tareas")]
        Task<Tareas> GuardarTareas(Tareas valor);
       
        [Get("/Tareas/{id}")]
        Task<Tareas> GetTarea(int id);

        [Delete("/Tareas/{id}")]
        Task<Tareas> BorrarTarea(int id);




        [Get("/Usuarios")]
        Task<List<Usuarios>> GetAllUsuario();
        
        [Get("/Usuarios/{id}")]
        Task<Usuarios> GetUsuario(int id);

        [Delete("/Usuarios/{id}")]
        Task<Usuarios> BorrarUsuario(int id);


        [Post("/Usuarios")]
        Task<Usuarios> GuardarUsuario(Usuarios valor);




        [Get("/Recursos")]
        Task<List<Recursos>> GetAllRecurso();

        [Post("/Recursos")]
        Task<Recursos> GuardarRecursos(Recursos valor);

        [Get("/Recursos/{id}")]
        Task<Recursos> GetRecurso(int id);

        [Delete("/Recursos/{id}")]
        Task<Recursos> BorrarRecurso(int id);





        [Get("/Detalles")]
        Task<List<Detalles>> GetAllDetalle();

        [Post("/Detalles")]
        Task<Detalles> GuardarDetalles(Detalles valor);

        [Get("/Detalles/{id}")]
        Task<Detalles> GetDetalles(int id);

        [Delete("/Detalles/{id}")]
        Task<Detalles> BorrarDetalle(int id);

    }
}
