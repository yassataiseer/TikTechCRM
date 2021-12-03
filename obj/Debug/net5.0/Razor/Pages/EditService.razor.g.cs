#pragma checksum "/Users/yassa/TikTechCRM/Pages/EditService.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "46532c15ce9d937d7dbe0b9ba7a5fa62d7edd4b4"
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
#line 33 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/editservice/{Service_name}/{Service_cost}/{Service_purpose}")]
    public partial class EditService : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<head><h1>Edit Service:</h1>\n    <h6><b>DO NOT USE THE FOLLOWING CHARACTERS: / \\ </b></h6></head>\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                  EditServiceModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                    HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.AddMarkupContent(13, "<h4>Service Name:</h4>\n    ");
                __builder2.AddMarkupContent(14, "<h6>***Cant be changed!!</h6>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(15);
                __builder2.AddAttribute(16, "type", "text");
                __builder2.AddAttribute(17, "id", "Service_name");
                __builder2.AddAttribute(18, "readonly", true);
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                           Service_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => Service_name = __value, Service_name))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => Service_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n    <br>\n    ");
                __builder2.AddMarkupContent(23, "<h4>Service Purpose:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "type", "text");
                __builder2.AddAttribute(26, "id", "Service_purpose");
                __builder2.AddAttribute(27, "placeholder", 
#nullable restore
#line 19 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                              Service_purpose

#line default
#line hidden
#nullable disable
                );
                __builder2.AddAttribute(28, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                                                            EditServiceModel.Service_purpose

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditServiceModel.Service_purpose = __value, EditServiceModel.Service_purpose))));
                __builder2.AddAttribute(30, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => EditServiceModel.Service_purpose));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(31, "\n    ");
                __builder2.AddMarkupContent(32, "<h4>Price:</h4>\n    ");
                __Blazor.TikTechCRM.Pages.EditService.TypeInference.CreateInputNumber_0(__builder2, 33, 34, "float", 35, "1", 36, "Service_cost", 37, 
#nullable restore
#line 21 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                                    Service_cost

#line default
#line hidden
#nullable disable
                , 38, 
#nullable restore
#line 21 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
                                                                                               EditServiceModel.Service_cost

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => EditServiceModel.Service_cost = __value, EditServiceModel.Service_cost)), 40, () => EditServiceModel.Service_cost);
                __builder2.AddMarkupContent(41, "\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(42, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(43);
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
#line 43 "/Users/yassa/TikTechCRM/Pages/EditService.razor"
    public EditServiceModel EditServiceModel = new();
    [Parameter]
    public string Service_name { get; set; }
    [Parameter]
    public string Service_purpose{ get; set; }
    [Parameter]
    public string Service_cost{ get; set; }



    public Validate Validate;
    public async void HandleValidSubmit(){
        Validate =  await Http.GetFromJsonAsync<Validate>("https://ticktechapi.pythonanywhere.com/Services/update_Services/"+Service_name+"/"+EditServiceModel.Service_purpose+"/"+EditServiceModel.Service_cost.ToString("0.00"));
        if (Validate.Status){         
            NavManager.NavigateTo("/services",true); 
        } 
        else {
            await JsRuntime.InvokeVoidAsync("alert", "Error!");
        }
    }
    protected override async Task OnInitializedAsync(){
       dynamic validate;
       validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       EditServiceModel.Service_cost = Convert.ToDouble(Service_cost);
       EditServiceModel.Service_purpose = Service_purpose;

       if(value==null){
            NavManager.NavigateTo("/",true); 
       }        
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
namespace __Blazor.TikTechCRM.Pages.EditService
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputNumber_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, System.Object __arg2, int __seq3, System.Object __arg3, int __seq4, TValue __arg4, int __seq5, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg5, int __seq6, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg6)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "type", __arg0);
        __builder.AddAttribute(__seq1, "min", __arg1);
        __builder.AddAttribute(__seq2, "id", __arg2);
        __builder.AddAttribute(__seq3, "placeholder", __arg3);
        __builder.AddAttribute(__seq4, "Value", __arg4);
        __builder.AddAttribute(__seq5, "ValueChanged", __arg5);
        __builder.AddAttribute(__seq6, "ValueExpression", __arg6);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
