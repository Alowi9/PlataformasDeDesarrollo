#pragma checksum "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bba7c16194b65de30add2f12fa082ec8bb8c23d8"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorApp1.Pages.Recursos
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
#line 2 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor"
using BlazorApp1.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Recursos/EditarRecurso/{id:int}")]
    public partial class EditarRecurso : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Crear Recurso</h3>\r\n\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(1);
            __builder.AddAttribute(2, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 8 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor"
                  Modelo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 8 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor"
                                          Guardar

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(4, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(5, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(6);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(7, "\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(8);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(9, "\r\n\r\n\r\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(10);
                __builder2.AddAttribute(11, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor"
                            Modelo.nombre

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(12, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Modelo.nombre = __value, Modelo.nombre))));
                __builder2.AddAttribute(13, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Modelo.nombre));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n    \r\n\r\n    ");
                __builder2.AddMarkupContent(15, "<button type=\"submit\">Guardar</button>\r\n");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "C:\Users\maxip\source\repos\Alowi9\PlataformasDeDesarrollo\13-10-2020\BlazorApp1\BlazorApp1\Pages\Recursos\EditarRecurso.razor"
       
    [Parameter]
    public int id { get; set; }

    public Recursos Modelo { get; set; } = new Recursos();

    protected override async Task OnInitializedAsync()
    {
        if (id > 0)
        {
            Modelo = await RecursosSer.Get(id);
        }
        else
        {
            Modelo = new Recursos();
        }
    }


    private async void Guardar()
    {
        await RecursosSer.Save(Modelo);
        navigation.NavigateTo("Recursos/ListadoDeRecursos");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigation { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private RecursosService RecursosSer { get; set; }
    }
}
#pragma warning restore 1591
