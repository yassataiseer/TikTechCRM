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
        }
        #pragma warning restore 1998
#nullable restore
#line 42 "/Users/yassa/TikTechCRM/Pages/NewService.razor"
    private ServiceFormModel ServiceFormModel = new();
    public Validate Validate;
    private async void  HandleValidSubmit()
    {
        Validate = await Http.GetFromJsonAsync<Validate>("https://ticktechapi.pythonanywhere.com/Services/mk_Service/"+ServiceFormModel.Service_name+"/"+ServiceFormModel.Service_purpose+"/"+ServiceFormModel.Service_cost.ToString("0.00"));
        if (Validate.Status){
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
        dynamic validate;
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       
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
#pragma warning restore 1591
