#pragma checksum "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Usuarios\ListadoDeUsuarios.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96e8fa8424ac39b768eba8beae0987d49fa5c704"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Usuarios
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\_Imports.razor"
using BlazorApp1.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Usuarios\ListadoDeUsuarios.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Usuarios/ListadoDeUsuarios")]
    public partial class ListadoDeUsuarios : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 38 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Usuarios\ListadoDeUsuarios.razor"
       
    private List<Usuarios> usuarios;

    protected override async Task OnInitializedAsync()
    {
        usuarios = await Usuario.GetAll();
        var tipos = await Usuario.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/Usuarios/EditarUsuario/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea eliminar el usuario?");
        if (confirmed)
        {
            await Usuario.Remove(id);
            usuarios = await Usuario.GetAll();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private UsuariosService Usuario { get; set; }
    }
}
#pragma warning restore 1591
