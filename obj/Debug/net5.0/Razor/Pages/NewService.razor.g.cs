#pragma checksum "/Users/yassa/TikTechCRM/Pages/NewService.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fd7a43a147a78836d348a3a19e55b6b7ae60642"
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
#line 32 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Newservice")]
    public partial class NewService : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<head><h1>New Service:</h1>\n    <h6><b>DO NOT USE THE FOLLOWING CHARACTERS: / \\ </b></h6></head>\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
                  ServiceFormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 12 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
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
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "id", "Service_name");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
                                                          ServiceFormModel.Service_name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ServiceFormModel.Service_name = __value, ServiceFormModel.Service_name))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ServiceFormModel.Service_name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n    <br>\n    ");
                __builder2.AddMarkupContent(21, "<h4>Service Purpose:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "id", "Service_purpose");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 18 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
                                                             ServiceFormModel.Service_purpose

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ServiceFormModel.Service_purpose = __value, ServiceFormModel.Service_purpose))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ServiceFormModel.Service_purpose));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n    ");
                __builder2.AddMarkupContent(29, "<h4>Price:</h4>\n    ");
                __Blazor.TikTechCRM.Pages.NewService.TypeInference.CreateInputNumber_0(__builder2, 30, 31, "float", 32, "1", 33, "Service_cost", 34, 
#nullable restore
#line 20 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
                                                                   ServiceFormModel.Service_cost

#line default
#line hidden
#nullable disable
                , 35, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ServiceFormModel.Service_cost = __value, ServiceFormModel.Service_cost)), 36, () => ServiceFormModel.Service_cost);
                __builder2.AddMarkupContent(37, "\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(38, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(39);
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
#line 41 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
    private dynamic validate;
    private ServiceFormModel ServiceFormModel = new();

    private async void  HandleValidSubmit()
    {
        using var client = new HttpClient();
        Console.WriteLine(ServiceFormModel.Service_cost.ToString("0.00"));
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Services/mk_Service/"+ServiceFormModel.Service_name+"/"+ServiceFormModel.Service_purpose+"/"+ServiceFormModel.Service_cost.ToString("0.00"));
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data.Status);
        if (data.Status=="true"){
            NavManager.NavigateTo("/services",true); 
        } 
        else {
            await JsRuntime.InvokeVoidAsync("alert", "Service is already taken");
        }
        //Console.WriteLine(LoginModel.Password);
        //Console.WriteLine("hello");
        // Process the valid form
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
namespace __Blazor.TikTechCRM.Pages.NewService
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
    }
}
#pragma warning restore 1591
