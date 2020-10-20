#pragma checksum "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3d86226e631830de95387800f86de0a94c4fa7e2"
// <auto-generated/>
#pragma warning disable 1591
namespace Connect.Client.Pages.Pedido
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\GitHub\Trabalho-OA\Connect\Client\_Imports.razor"
using Connect.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Pedido/ListPedido")]
    public partial class ListPedido : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Pedido</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "card-body");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.OpenElement(4, "table");
            __builder.AddAttribute(5, "class", "table");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.AddMarkupContent(7, "<thead>\r\n            <tr>\r\n                <th scope=\"col\">Item</th>\r\n                <th scope=\"col\">ValorTotal</th>\r\n            </tr>\r\n        </thead>\r\n        ");
            __builder.OpenElement(8, "tbody");
            __builder.AddMarkupContent(9, "\r\n");
#nullable restore
#line 17 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
             foreach (var item in pedidoList)
            {

#line default
#line hidden
#nullable disable
            __builder.AddContent(10, "            ");
            __builder.OpenElement(11, "tr");
            __builder.AddMarkupContent(12, "\r\n                ");
            __builder.OpenElement(13, "td");
            __builder.AddContent(14, 
#nullable restore
#line 20 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
                     item.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(15, "\r\n                ");
            __builder.OpenElement(16, "td");
            __builder.AddContent(17, 
#nullable restore
#line 21 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
                     item.ValorTotal

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\r\n                ");
            __builder.OpenElement(19, "td");
            __builder.AddMarkupContent(20, "\r\n                    ");
            __builder.OpenElement(21, "a");
            __builder.AddAttribute(22, "href", "/Pedido/EditPedido/" + (
#nullable restore
#line 23 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
                                                 item.Id.ToString()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(23, "<button class=\"btn btn-success\">Editar</button>");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-danger");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
                                                               () => DeletePedido(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Delete");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(31, "\r\n");
#nullable restore
#line 27 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
            }   

#line default
#line hidden
#nullable disable
            __builder.AddContent(32, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(33, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 32 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Pedido\ListPedido.razor"
       

    private List<Pedido> pedidoList = new List<Pedido>();

    protected override async Task OnInitializedAsync()
    {

        var pedidos = await Http.GetFromJsonAsync<List<Pedido>>("/Pedido/List");
        foreach (var item in pedidos)
        {
            pedidoList.Add(item);
        }
    }

    private async Task DeletePedido(int itemId)
    {
        //call controller
        await Http.DeleteAsync("/Pedido/Delete/"+itemId);
        NavigationManager.NavigateTo("Pedido/ListPedido", true);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591