#pragma checksum "/Users/yassa/TikTechCRM/Pages/NewClient.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36a3a1e232cd3d19f7028f552cfb1691c05fa329"
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
#line 40 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 43 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 44 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/newclient")]
    public partial class NewClient : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<head><h1>New Client:</h1>\n    <h6><b>DO NOT USE THE FOLLOWING CHARACTERS: / \\ </b></h6></head>\n");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "card");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(7);
            __builder.AddAttribute(8, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 13 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                  ClientFormModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(9, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 13 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                   HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(10, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(11);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(12, "\n    ");
                __builder2.AddMarkupContent(13, "<h4>Client Name:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(14);
                __builder2.AddAttribute(15, "type", "text");
                __builder2.AddAttribute(16, "id", "Item");
                __builder2.AddAttribute(17, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 16 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                  ClientFormModel.Username

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(18, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ClientFormModel.Username = __value, ClientFormModel.Username))));
                __builder2.AddAttribute(19, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ClientFormModel.Username));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\n    <br>\n    ");
                __builder2.AddMarkupContent(21, "<h4>Email:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(22);
                __builder2.AddAttribute(23, "type", "text");
                __builder2.AddAttribute(24, "id", "Barcode");
                __builder2.AddAttribute(25, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 19 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                     ClientFormModel.Email

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(26, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ClientFormModel.Email = __value, ClientFormModel.Email))));
                __builder2.AddAttribute(27, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ClientFormModel.Email));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(28, "\n    <br>\n    ");
                __builder2.AddMarkupContent(29, "<h4>Phone Number:</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(30);
                __builder2.AddAttribute(31, "type", "text");
                __builder2.AddAttribute(32, "id", "Phone_Number");
                __builder2.AddAttribute(33, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 22 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                          ClientFormModel.Phone_Number

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(34, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ClientFormModel.Phone_Number = __value, ClientFormModel.Phone_Number))));
                __builder2.AddAttribute(35, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ClientFormModel.Phone_Number));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(36, "\n    <br>\n    ");
                __builder2.AddMarkupContent(37, "<h4>Address: </h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(38);
                __builder2.AddAttribute(39, "type", "text");
                __builder2.AddAttribute(40, "id", "Address");
                __builder2.AddAttribute(41, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 25 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                      ClientFormModel.Address

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(42, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ClientFormModel.Address = __value, ClientFormModel.Address))));
                __builder2.AddAttribute(43, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ClientFormModel.Address));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(44, "\n    <br>\n    ");
                __builder2.AddMarkupContent(45, "<h4>Postal Code</h4>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(46);
                __builder2.AddAttribute(47, "type", "text");
                __builder2.AddAttribute(48, "id", "Postal_code");
                __builder2.AddAttribute(49, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 28 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
                                                          ClientFormModel.Postal_code

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(50, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => ClientFormModel.Postal_code = __value, ClientFormModel.Postal_code))));
                __builder2.AddAttribute(51, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => ClientFormModel.Postal_code));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(52, "\n    <br>\n    <br>\n    ");
                __builder2.AddMarkupContent(53, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(54);
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
#line 49 "/Users/yassa/TikTechCRM/Pages/NewClient.razor"
    private dynamic validate;
    private ClientFormModel ClientFormModel = new();

    private async void  HandleValidSubmit()
    {
        using var client = new HttpClient();
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Clients/mk_Client/"+ClientFormModel.Username+"/"+ClientFormModel.Address+"/"+ClientFormModel.Postal_code+"/"+ClientFormModel.Email+"/"+ClientFormModel.Phone_Number.ToString());
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data.Status);
        if (data.Status=="true"){
            NavManager.NavigateTo("/Clients",true); 
        } 
        else {
            await JsRuntime.InvokeVoidAsync("alert", "Error!");
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
#pragma warning restore 1591
