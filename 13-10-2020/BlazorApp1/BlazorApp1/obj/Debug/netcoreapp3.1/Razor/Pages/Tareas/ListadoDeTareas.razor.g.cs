#pragma checksum "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72fd6942fbd2c788fa4e3df19512e8823102185e"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Tareas
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
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Tareas/ListadoDeTareas")]
    public partial class ListadoDeTareas : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Listado De Tareas</h3>\r\n\r\n");
            __builder.OpenElement(1, "button");
            __builder.AddAttribute(2, "class", "btn");
            __builder.AddAttribute(3, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 9 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                              ()=>Editar(0)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(4, "Nueva Tarea");
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n");
#nullable restore
#line 11 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
 if (Tarea == null)
{

}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(6, "    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "\r\n        ");
            __builder.AddMarkupContent(10, "<thead>\r\n            <tr>\r\n                <th>Titulo</th>\r\n                <th>Vencimiento</th>\r\n                <th>Estimacion</th>\r\n                <th>Estado</th>\r\n\r\n                <th>Acciones</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(11, "tbody");
            __builder.AddMarkupContent(12, "\r\n");
#nullable restore
#line 29 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
             foreach (var item in Tarea)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(13, "            ");
            __builder.OpenElement(14, "tr");
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 32 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                     item.titulo

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddContent(20, 
#nullable restore
#line 33 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                     item.vencimiento

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "td");
            __builder.AddContent(23, 
#nullable restore
#line 34 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                     item.estimacion

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "td");
            __builder.AddContent(26, 
#nullable restore
#line 35 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                     item.estado

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n                ");
            __builder.OpenElement(28, "td");
            __builder.OpenElement(29, "button");
            __builder.AddAttribute(30, "class", "btn");
            __builder.AddAttribute(31, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                                                  ()=>Editar(item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(32, "Editar");
            __builder.CloseElement();
            __builder.AddContent(33, " ");
            __builder.OpenElement(34, "button");
            __builder.AddAttribute(35, "class", "btn");
            __builder.AddAttribute(36, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
                                                                                                                     ()=>Borrar(item.id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(37, "Borrar");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
#nullable restore
#line 38 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.AddContent(40, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n");
#nullable restore
#line 41 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Tareas\ListadoDeTareas.razor"
       


    /*protected override async Task OnInitializedAsync()
    {
        tareas = TareaServicio.getTareas();
    }
    */
    private List<Tareas> Tarea;

    protected override async Task OnInitializedAsync()
    {
        Tarea = await TareaServicio.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/Tareas/EditarTarea/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el usuario?");
        if (confirmed)
        {
            await TareaServicio.Remove(id);
            Tarea = await TareaServicio.GetAll();
        }
    }






#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private TareasService TareaServicio { get; set; }
    }
}
#pragma warning restore 1591
