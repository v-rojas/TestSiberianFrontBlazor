#pragma checksum "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\Pages\EliminarCiudad.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "498bd92db3d29dfc3e0ce1901b45274ffcd28e30"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorFront.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\_Imports.razor"
using BlazorFront.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\Pages\EliminarCiudad.razor"
using Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminarciudad")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/eliminarciudad/{Id:int}")]
    public partial class EliminarCiudad : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "C:\Users\Washington\source\repos\BlazorFront\BlazorFront\Pages\EliminarCiudad.razor"
       
    [Parameter]
    public int Id { get; set; }
    CiudadModelo c = new CiudadModelo();
    List<CiudadModelo> ciudades = new List<CiudadModelo>();

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (firstRender)
        {
            if (Id != 0)
            {
                CiudadModelo ciudad = new CiudadModelo();
                ciudad.Codigo = "4";
                ciudad.IDCiudad = Id.ToString();
                ciudad.Token = await sessionStorage.GetItemAsync<string>("token_ciudad");
                ciudades = await CiudadService.CrudCiudad(ciudad);
                c = ciudades.First();
            }
            StateHasChanged();
        }
    }

    private async Task EliminarRegistro()
    {
        if (Id != 0)
        {
            c.Codigo = "5";
            c.Token = await sessionStorage.GetItemAsync<string>("token_ciudad");
            await CiudadService.CrudCiudad(c);
        }
        NavigationManager.NavigateTo("/ciudadpage");
    }

    private void Regresar()
    {
        NavigationManager.NavigateTo("/ciudadpage");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private Blazored.SessionStorage.ISessionStorageService sessionStorage { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private CiudadService CiudadService { get; set; }
    }
}
#pragma warning restore 1591