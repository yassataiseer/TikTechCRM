#pragma checksum "/Users/yassa/TikTechCRM/Pages/NewInventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0cd376a3a6c18a6479743258a16f8e8d6e2525e"
// <auto-generated/>
#pragma warning disable 1591
namespace TikTechCRM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 3 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/Users/yassa/TikTechCRM/_Imports.razor"
using TikTechCRM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/yassa/TikTechCRM/_Imports.razor"
using TikTechCRM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/yassa/TikTechCRM/_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/yassa/TikTechCRM/_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/yassa/TikTechCRM/_Imports.razor"
[Authorize]

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newinventory")]
    public partial class NewInventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<head><h1>Add to Inventory:</h1></head>\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                  InventoryFormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                                                      HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.AddMarkupContent(13, "<h4>Item Name:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "id", "Item");
                __builder2.AddAttribute(17, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                                                  InventoryFormModel.Item

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InventoryFormModel.Item = __value, InventoryFormModel.Item))));
                __builder2.AddAttribute(19, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InventoryFormModel.Item));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n    <br>\n    ");
                __builder2.AddMarkupContent(21, "<h4>Barcode:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "id", "Barcode");
                __builder2.AddAttribute(25, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                                                     InventoryFormModel.Barcode

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InventoryFormModel.Barcode = __value, InventoryFormModel.Barcode))));
                __builder2.AddAttribute(27, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => InventoryFormModel.Barcode));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.AddMarkupContent(29, "<h4>Price:</h4>\n    ");
                __Blazor.TikTechCRM.Pages.NewInventory.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "float", 32, "1", 33, "Price", 34, 
#nullable restore
#line 20 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                                                            InventoryFormModel.Price

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InventoryFormModel.Price = __value, InventoryFormModel.Price)), 36, () => InventoryFormModel.Price);
                __builder2.AddMarkupContent(37, "\n    ");
                __builder2.AddMarkupContent(38, "<h4>Quantity:</h4>\n    ");
                __Blazor.TikTechCRM.Pages.NewInventory.TypeInference.CreateInputNumber_1(__builder2, 39, 40, "number", 41, "0", 42, "Quantity", 43, 
#nullable restore
#line 22 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                                                                InventoryFormModel.Quantity

#line default
#line hidden
#nullable disable
                , 44, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InventoryFormModel.Quantity = __value, InventoryFormModel.Quantity)), 45, () => InventoryFormModel.Quantity);
                __builder2.AddMarkupContent(46, "\n    ");
                __builder2.AddMarkupContent(47, "<h4>Status: </h4>\n    ");
                __Blazor.TikTechCRM.Pages.NewInventory.TypeInference.CreateInputSelect_2(__builder2, 48, 49, 
#nullable restore
#line 24 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
                              InventoryFormModel.Status

#line default
#line hidden
#nullable disable
                , 50, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => InventoryFormModel.Status = __value, InventoryFormModel.Status)), 51, () => InventoryFormModel.Status, 52, (__builder3) => {
                    __builder3.AddMarkupContent(53, "<option value></option>\n         ");
                    __builder3.AddMarkupContent(54, "<option value=\"Empty\">Empty</option>\n         ");
                    __builder3.AddMarkupContent(55, "<option value=\"Full\">Full</option>\n         ");
                    __builder3.AddMarkupContent(56, "<option value=\"Almost empty\">Almost empty</option>");
                }
                );
                __builder2.AddMarkupContent(57, "\n\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(58, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(59);
                __builder2.CloseComponent();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "/Users/yassa/TikTechCRM/Pages/NewInventory.razor"
    private dynamic validate;
    private InventoryFormModel InventoryFormModel = new();

    private async void  HandleValidSubmit()
    {
        using var client = new HttpClient();
        var result = await client.GetStringAsync("http://0.0.0.0:800/Inventory/mk_Inventory/"+InventoryFormModel.Item+"/"+InventoryFormModel.Barcode+"/"+InventoryFormModel.Price.ToString("0.00")+"/"+InventoryFormModel.Quantity+"/"+InventoryFormModel.Status);
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data.Status);
        if (data.Status=="true"){
            NavManager.NavigateTo("/inventory",true); 
        } 
        else {
            await JsRuntime.InvokeVoidAsync("alert", "Service is already taken");
        }        
    }

    protected override async Task OnInitializedAsync(){
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       
       if(value==null){
            NavManager.NavigateTo("/",true); 
       }        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.TikTechCRM.Pages.NewInventory
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
        public static void CreateInputSelect_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg1, int __seq2, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg2, int __seq3, global::Microsoft.AspNetCore.Components.RenderFragment __arg3)
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
