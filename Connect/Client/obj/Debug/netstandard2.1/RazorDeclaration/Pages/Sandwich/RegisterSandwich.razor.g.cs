#pragma checksum "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d466740a18666a926dc621b808397aaa69aab22d"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Connect.Client.Pages.Sandwich
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
#line 2 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Sandwich/RegisterSandwich")]
    public partial class RegisterSandwich : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 41 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
       

    private SandwichDTO sandwichDTO = new SandwichDTO();

    private EditContext editContext { get; set; }
    
    private List<Category> categoriesList = new List<Category>();

    protected override async Task OnInitializedAsync()
    {
        var categories = await Http.GetFromJsonAsync<List<Category>>("/Category/List");
        foreach (var item in categories)
        {
            categoriesList.Add(item);
        }
    }

    private async Task HandleValidSubmit()
    {
        var teste = await Http.PostAsJsonAsync("/Sandwich/Create", sandwichDTO);
        NavigationManager.NavigateTo("Sandwich/ListSandwich");
    }

    private void HandleReset()
    {
        sandwichDTO = new SandwichDTO();
        editContext = new EditContext(sandwichDTO);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
