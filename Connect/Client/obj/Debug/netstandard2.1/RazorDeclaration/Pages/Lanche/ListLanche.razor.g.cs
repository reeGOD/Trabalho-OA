#pragma checksum "h:\GitHub\Trabalho-OA\Connect\Client\Pages\Lanche\ListLanche.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9b761d87c9e4787d001a0f9fa97c3a5130e2b45"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Connect.Client.Pages.Lanche
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "h:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "h:\GitHub\Trabalho-OA\Connect\Client\Pages\Lanche\ListLanche.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Lanche/ListLanche")]
    public partial class ListLanche : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 34 "h:\GitHub\Trabalho-OA\Connect\Client\Pages\Lanche\ListLanche.razor"
       

    private List<Lanche> lancheList = new List<Lanche>();

    protected override async Task OnInitializedAsync()
    {

        var lanches = await Http.GetFromJsonAsync<List<Lanche>>("/Lanche/List");
        foreach (var item in lanches)
        {
            lancheList.Add(item);
        }
    }

    private async Task DeleteLanche(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Lanche/Delete/"+itemId);
        NavigationManager.NavigateTo("Lanche/ListLanche", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
