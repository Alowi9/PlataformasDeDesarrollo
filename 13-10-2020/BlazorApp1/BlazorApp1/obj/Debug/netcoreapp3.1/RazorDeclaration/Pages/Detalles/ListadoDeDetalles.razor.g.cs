#pragma checksum "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDeDetalles.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2aa8c501a6df952d3ce830550485ff11de4487bf"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorApp1.Pages.Detalles
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
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDeDetalles.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Detalles/ListadoDeDetalles")]
    public partial class ListadoDeDetalles : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Detalles\ListadoDeDetalles.razor"
       
    /*
    private List<Detalles> Detalles;

    protected override async Task OnInitializedAsync()
    {
        Detalles = Detalle.getDetalles();
    }

        */





    private List<Detalles> detalles;

    protected override async Task OnInitializedAsync()
    {
        detalles = await DetalleSer.GetAll();
    }

    protected void Editar(int id)
    {
        navigation.NavigateTo("/Detalles/EditarDetalle/" + id);
    }

    async Task Borrar(int id)
    {
        bool confirmed = await JsRuntime.InvokeAsync<bool>("confirm", "Desea elimiar el detalle?");
        if (confirmed)
        {
            await DetalleSer.Remove(id);
            detalles = await DetalleSer.GetAll();
        }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private DetallesService DetalleSer { get; set; }
    }
}
#pragma warning restore 1591
