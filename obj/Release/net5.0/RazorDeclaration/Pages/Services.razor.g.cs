// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
            var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Services/all_Services");

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
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Services/del_Services/"+Service_name);
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
