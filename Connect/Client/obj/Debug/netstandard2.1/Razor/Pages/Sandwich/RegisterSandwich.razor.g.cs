#pragma checksum "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d466740a18666a926dc621b808397aaa69aab22d"
// <auto-generated/>
#pragma warning disable 1591
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "card m-3");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<h4 class=\"card-header\">Cadastro de Lanche</h4>\r\n    ");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.AddMarkupContent(6, "\r\n        ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 9 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                          sandwichDTO

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 9 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "onreset", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.EventArgs>(this, 
#nullable restore
#line 9 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                                                                   HandleReset

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.AddMarkupContent(12, "\r\n            ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\r\n            ");
                __builder2.OpenElement(15, "div");
                __builder2.AddAttribute(16, "class", "form-row");
                __builder2.AddMarkupContent(17, "\r\n                ");
                __builder2.AddMarkupContent(18, "<label>Nome do Lanche:</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(19);
                __builder2.AddAttribute(20, "class", "form-control");
                __builder2.AddAttribute(21, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 13 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                        sandwichDTO.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(22, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sandwichDTO.Name = __value, sandwichDTO.Name))));
                __builder2.AddAttribute(23, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sandwichDTO.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(24, "\r\n                ");
                __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich.TypeInference.CreateValidationMessage_0(__builder2, 25, 26, 
#nullable restore
#line 14 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                          () => sandwichDTO.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(27, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(28, "\r\n            ");
                __builder2.OpenElement(29, "div");
                __builder2.AddAttribute(30, "class", "form-row");
                __builder2.AddMarkupContent(31, "\r\n                ");
                __builder2.AddMarkupContent(32, "<label>Descrição</label>\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(33);
                __builder2.AddAttribute(34, "class", "form-control");
                __builder2.AddAttribute(35, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                        sandwichDTO.Description

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(36, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sandwichDTO.Description = __value, sandwichDTO.Description))));
                __builder2.AddAttribute(37, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => sandwichDTO.Description));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(38, "\r\n                ");
                __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich.TypeInference.CreateValidationMessage_1(__builder2, 39, 40, 
#nullable restore
#line 19 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                          () => sandwichDTO.Description

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(41, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(42, "\r\n            ");
                __builder2.OpenElement(43, "div");
                __builder2.AddAttribute(44, "class", "form-row");
                __builder2.AddMarkupContent(45, "\r\n                ");
                __builder2.AddMarkupContent(46, "<label>Preço</label>\r\n                ");
                __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich.TypeInference.CreateInputNumber_2(__builder2, 47, 48, "form-control", 49, 
#nullable restore
#line 23 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                          sandwichDTO.Price

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sandwichDTO.Price = __value, sandwichDTO.Price)), 51, () => sandwichDTO.Price);
                __builder2.AddMarkupContent(52, "\r\n                ");
                __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich.TypeInference.CreateValidationMessage_3(__builder2, 53, 54, 
#nullable restore
#line 24 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                          () => sandwichDTO.Price

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(55, "\r\n            ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n            ");
                __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich.TypeInference.CreateInputSelect_4(__builder2, 57, 58, 
#nullable restore
#line 26 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                      sandwichDTO.CategoryId

#line default
#line hidden
#nullable disable
                , 59, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => sandwichDTO.CategoryId = __value, sandwichDTO.CategoryId)), 60, () => sandwichDTO.CategoryId, 61, (__builder3) => {
                    __builder3.AddMarkupContent(62, "\r\n                ");
                    __builder3.AddMarkupContent(63, "<option value>Select</option>\r\n");
#nullable restore
#line 28 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                 foreach (var category in categoriesList)
                {

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(64, "                    ");
                    __builder3.OpenElement(65, "option");
                    __builder3.AddAttribute(66, "value", 
#nullable restore
#line 30 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                    category.CategoryId

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddContent(67, 
#nullable restore
#line 30 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                                                          category.Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(68, "\r\n");
#nullable restore
#line 31 "H:\GitHub\Trabalho-OA\Connect\Client\Pages\Sandwich\RegisterSandwich.razor"
                }

#line default
#line hidden
#nullable disable
                    __builder3.AddContent(69, "            ");
                }
                );
                __builder2.AddMarkupContent(70, "\r\n            ");
                __builder2.AddMarkupContent(71, "<div class=\"text-center\">\r\n                <button type=\"submit\" class=\"btn btn-primary mr-1\">Salvar</button>\r\n                <button type=\"reset\" class=\"btn btn-secondary\">Cancel</button>\r\n            </div>\r\n        ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(72, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n");
            __builder.CloseElement();
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
namespace __Blazor.Connect.Client.Pages.Sandwich.RegisterSandwich
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputSelect<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "ValueChanged", __arg1);
        __builder.AddAttribute(__seq2, "ValueExpression", __arg2);
        __builder.AddAttribute(__seq3, "ChildContent", __arg3);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
