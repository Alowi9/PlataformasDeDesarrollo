using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface RemoteService
    {

        [Get("/TipoTarea")]
        Task<List<Tareas>> GetAllTipoTarea();

        [Get("/Usuarios")]
        Task<List<Usuarios>> GetAllUsuario();





    }
}
