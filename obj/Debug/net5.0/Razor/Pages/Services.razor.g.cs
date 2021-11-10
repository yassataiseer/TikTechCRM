#pragma checksum "/Users/yassa/TikTechCRM/Pages/Services.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b98a60130061702197ac5cd3b698a2d54f7be4a1"
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
#line 36 "/Users/yassa/TikTechCRM/Pages/Services.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 37 "/Users/yassa/TikTechCRM/Pages/Services.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 38 "/Users/yassa/TikTechCRM/Pages/Services.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 39 "/Users/yassa/TikTechCRM/Pages/Services.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 40 "/Users/yassa/TikTechCRM/Pages/Services.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 41 "/Users/yassa/TikTechCRM/Pages/Services.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/services")]
    public partial class Services : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "<h1>Services</h1>\r\n    <br>\r\n    ");
            __builder.OpenElement(2, "button");
            __builder.AddAttribute(3, "class", "btn btn-info");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                                            () => NewService()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(5, "<i class=\"oi oi-plus\"></i> Service");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, " \r\n    <br>\r\n    ");
            __builder.OpenElement(7, "table");
            __builder.AddAttribute(8, "class", "table");
            __builder.AddMarkupContent(9, "<thead><tr><th>Name</th>\r\n                <th>Purpose</th>\r\n                <th>Cost</th></tr></thead>\r\n        ");
            __builder.OpenElement(10, "tbody");
#nullable restore
#line 18 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                 foreach (var Services in ServiceData)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(11, "tr");
            __builder.OpenElement(12, "td");
            __builder.AddContent(13, 
#nullable restore
#line 21 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                         Services.Service_name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                    ");
            __builder.OpenElement(15, "td");
            __builder.AddContent(16, 
#nullable restore
#line 22 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                         Services.Service_purpose

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                    ");
            __builder.OpenElement(18, "td");
            __builder.AddContent(19, "$");
            __builder.AddContent(20, 
#nullable restore
#line 23 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                          Services.Service_cost

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                    ");
            __builder.OpenElement(22, "button");
            __builder.AddAttribute(23, "class", "btn btn-primary");
            __builder.AddAttribute(24, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 24 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                                                              () => EditRedirect(Services.Service_name,Services.Service_purpose,Services.Service_cost)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(25, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\r\n                    ");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "type", "button");
            __builder.AddAttribute(29, "class", "btn btn-danger");
            __builder.AddAttribute(30, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                                                                           () => DeleteService(Services.Service_name)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(31, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 28 "/Users/yassa/TikTechCRM/Pages/Services.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/Services.razor"
    private List<ServiceModel> ServiceData = new();
    private dynamic validate;

    protected override async Task OnInitializedAsync(){
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       if(value==null){
            NavManager.NavigateTo("/",true); 
       }
            using var client = new HttpClient();
            var result = await client.GetStringAsync("http://0.0.0.0:800/Services/all_Services");

            JArray data = JArray.Parse(result);
            foreach (dynamic obj in data){
                    ServiceData.Add(new ServiceModel(){
                        Service_cost = obj.Service_cost,
                        Service_name  = obj.Service_name,
                        Service_purpose = obj.Service_purpose
                });
            }

        StateHasChanged();

    }
    public void NewService(){
        NavManager.NavigateTo("/Newservice",true); 
    }
    private async void DeleteService(string Service_name){
        using var client = new HttpClient();
        var result = await client.GetStringAsync("http://0.0.0.0:800/Services/del_Services/"+Service_name);
        NavManager.NavigateTo("/Services",true); 
    }
    private void EditRedirect(string Service_name, string Service_purpose, double Service_cost){
         NavManager.NavigateTo("/editservice/"+Service_name+"/"+Service_purpose+"/"+Service_cost.ToString(),true); 
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
