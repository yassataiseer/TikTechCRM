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
#line 200 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 201 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "/Users/yassa/TikTechCRM/Pages/Login.razor"
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
    [Microsoft.AspNetCore.Components.LayoutAttribute(typeof(EmptyLayout))]
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Login : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 209 "/Users/yassa/TikTechCRM/Pages/Login.razor"

    private LoginModel LoginModel = new();

    private async void  HandleValidSubmit()
    {
        using var client = new HttpClient();
        var result = await client.GetStringAsync("http://0.0.0.0:800/Users/validate_user/"+LoginModel.UserName+"/"+LoginModel.Password);
        dynamic data = JObject.Parse(result);
        Console.WriteLine(data.Status);
        if (data.Status=="true"){
            await JsRuntime.InvokeVoidAsync("BlazorSetLocalStorage", "Username:", LoginModel.UserName);
            //await JsRuntime.InvokeAsync<bool>("WriteCookie",  "Username", LoginModel.Password, 1);
            //await localStorage.SetItemAsync("Username", "LoginModel.UserName");
            //var Username = await localStorage.GetItemAsync<string>("Username");
            //await JSRuntime.InvokeAsync<bool>( "Username", LoginModel.UserName);            
            //Console.WriteLine(Username);
            NavManager.NavigateTo("/Users",true); 
        } 
        else {
            await JsRuntime.InvokeVoidAsync("alert", "Invalid Creds.");
        }
        


        //Console.WriteLine(LoginModel.Password);
        //Console.WriteLine("hello");
        // Process the valid form
    }
        protected override async Task OnInitializedAsync()
    {

        await JsRuntime.InvokeVoidAsync("BlazorRemoveCookie","Username:");
       
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
