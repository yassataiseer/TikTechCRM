#pragma checksum "/Users/yassa/TikTechCRM/Pages/Login.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09d0a76bc2a965f9c69d83c37be1d3d8e5c37434"
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
#line 201 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 202 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 203 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 204 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 205 "/Users/yassa/TikTechCRM/Pages/Login.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 206 "/Users/yassa/TikTechCRM/Pages/Login.razor"
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
            __builder.AddMarkupContent(0, "<!DOCTYPE html>\n\n");
            __builder.OpenElement(1, "html");
            __builder.AddMarkupContent(2, "<style>\nhtml {\n    height: 100%;\n  }\n  \n  body {\n    font-family: Arial, Helvetica, sans-serif;\n  background-color:rgb(255,255,255);\n}\n  h1{\n      color:rgb(255,255,255);\n  }\n  h3,h2{\n      color:rgb(0, 35, 102);\n  }\n  h6{\n    color:rgb(\t0, 35, 102);\n}\n  input[type=text], input[type=password],input[type=number] {\n    width: 100%;\n    padding: 12px 20px;\n    margin: 8px 0;\n    display: inline-block;\n    border: 1px solid #ccc;\n    box-sizing: border-box;\n  }\n  body{\n      background-color:rgb(255,255,255);\n  }\n\n  input[type=text],input[type=number] {\n   background-color: rgb(252, 255, 255);\n   color:rgb(0, 0, 0);\n  }\n  input[type=password] {\n   background-color: rgb(252, 255, 255);\n   color:rgb(0,0,0);\n  }\n  .cancelbtn {\n    width: auto;\n    padding: 10px 18px;\n    background-color: #f44336;\n  }\n  \n  .imgcontainer {\n    text-align: center;\n    margin: 24px 0 12px 0;\n  }\n  \n  img.avatar {\n    width: 40%;\n    border-radius: 50%;\n  }\n  \n  .container {\n    padding: 16px;\n  }\n  \n  span.psw {\n    float: right;\n    padding-top: 16px;\n  }\n\n  \n  .card {\n    box-shadow: 0 4px 8px 0 rgb(0,0,0,0.2);\n    transition: 0.3s;\n    background:rgb(255,255,255);\n    width: 30%;\n    margin:  0px auto;\n  \n  }\n  \n  .card:hover {\n    box-shadow: 0 8px 16px 0 rgba(0,0,0,0.2);\n  }\n  \n  .container {\n    padding: 2px 16px;\n  }\n  \n  .topnav {\n    overflow: hidden;\n    background-color:rgb(\t0, 35, 102);\n    position: fixed;\n    top: 0;\n    text-align: center;\n    width: 100%;\n    position: absolute;\n    right: 5px;\n  }\n  \n  \n  .topnav a {\n    float: left;\n    color: rgb(\t0, 35, 102);\n    text-align: center;\n    padding: 14px 16px;\n    text-decoration: none;\n    font-size: 17px;\n  }\n   .home_button {\n    float: right;\n    background-color: rgb(0, 35, 102); /* Blue background */\n    color: rgb(255,254,240);\n    text-align: right;\n    font-size: 17px;\n  }\n  .home_button:hover {\n    color:rgb(0, 35, 102) ;\n  background-color:rgb(255,254,240);\n}\n  .topnav a:hover {\n    background-color: rgb(0, 35, 102);\n    color: black;\n  }\n   \n  \n  \n  .topnav a.active {\n    background-color: rgb(0, 35, 102);\n    color: white;\n  }\n  \n\n  \n\n  .wrapper {\n    text-align: center;\n}\n\n  /* Darker background on mouse-over */\n\n  \n\n\n  body{\n    font-family:Verdana, Geneva, sans-serif;\n    font-size:18px;\n    background-color:rgb(255,255,255);\n  }\n  \n  .float{\n    position:fixed;\n    width:60px;\n    height:60px;\n    bottom:40px;\n    right:40px;\n    background-color:rgb(0, 35, 102);\n    color:rgb(255,254,240);\n    border-radius:50px;\n    text-align:center;\n    box-shadow: 2px 2px 3px #999;\n  }\n  \n  .my-float{\n    margin-top:22px;\n  }\n  .row,.col-xl-6{\n    text-align: center;\n  }\n    </style>\n");
            __builder.AddMarkupContent(3, "<head><meta name=\"viewport\" content=\"width=device-width, initial-scale=1\"></head>\n");
            __builder.AddMarkupContent(4, "<div class=\"topnav\"><a><h1>Tik Tech CRM </h1></a></div>\n<br>\n<br>\n<br>\n<br>\n<br>\n<br>\n\n");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "card");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "container");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(9);
            __builder.AddAttribute(10, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 184 "/Users/yassa/TikTechCRM/Pages/Login.razor"
                  LoginModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(11, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 184 "/Users/yassa/TikTechCRM/Pages/Login.razor"
                                              HandleValidSubmit

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(13);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(14, "\n    ");
                __builder2.AddMarkupContent(15, "<h3>Username</h3>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "type", "text");
                __builder2.AddAttribute(18, "id", "UserName");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 187 "/Users/yassa/TikTechCRM/Pages/Login.razor"
                                                      LoginModel.UserName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginModel.UserName = __value, LoginModel.UserName))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginModel.UserName));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\n    <br>\n    ");
                __builder2.AddMarkupContent(23, "<h3>Password</h3>\n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "type", "password");
                __builder2.AddAttribute(26, "id", "Password");
                __builder2.AddAttribute(27, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 190 "/Users/yassa/TikTechCRM/Pages/Login.razor"
                                                          LoginModel.Password

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(28, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => LoginModel.Password = __value, LoginModel.Password))));
                __builder2.AddAttribute(29, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => LoginModel.Password));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(30, "\n    <br>\n    <br>\n    \n    ");
                __builder2.AddMarkupContent(31, "<button type=\"submit\" class=\"btn btn-primary\">Submit</button> \n    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(32);
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
#line 210 "/Users/yassa/TikTechCRM/Pages/Login.razor"

    private LoginModel LoginModel = new();

    private async void  HandleValidSubmit()
    {
        using var client = new HttpClient();
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Users/validate_user/"+LoginModel.UserName+"/"+LoginModel.Password);
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
