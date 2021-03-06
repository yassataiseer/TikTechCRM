#pragma checksum "/Users/yassa/TikTechCRM/Pages/Clients.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "74b89ea8fcfbcc3ececa5633b7c393e50b829067"
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
#line 56 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 61 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Clients")]
    public partial class Clients : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "<h1>Clients</h1>");
#nullable restore
#line 5 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
     if(ClientData==null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, @"<div id=""app"" style=""margin: 0 auto; width: 100vw; height: 100vh""><div class=""text-center pt-3"" style=""color: rgb(5, 39, 103); font-size: 16pt"">
          Loading...
        </div>
        <div class=""text-center mt-3""><span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true"" style=""font-size: 16pt; width: 36px; height: 36px; color: rgb(5, 39, 103)""></span></div>
        <div class=""text-center""></div></div>");
#nullable restore
#line 17 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
}

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(3, "<br>\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "btn btn-info");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 19 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                                             () => Redirect()

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(7);
            __builder.AddAttribute(8, "Text", "New Client");
            __builder.AddAttribute(9, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(10, "<i class=\"oi oi-plus\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddContent(11, " Client");
            __builder.CloseElement();
            __builder.AddMarkupContent(12, " \n    <br>\n    ");
            __builder.OpenElement(13, "table");
            __builder.AddAttribute(14, "class", "table");
            __builder.AddMarkupContent(15, "<thead><tr><th>Name</th>\n                <th>Address</th>\n                <th>Postal Code</th>\n                <th>Email</th>\n                <th>Phone Number</th></tr></thead>\n       ");
            __builder.OpenElement(16, "tbody");
#nullable restore
#line 32 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                 foreach (var Current_Client in ClientData)
                {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 34 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                     if(!@Current_Client.Deleted){


#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "tr");
            __builder.OpenElement(18, "td");
#nullable restore
#line 37 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
__builder.AddContent(19, Current_Client.Username);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.OpenElement(21, "td");
#nullable restore
#line 38 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
__builder.AddContent(22, Current_Client.Address);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n                        ");
            __builder.OpenElement(24, "td");
#nullable restore
#line 39 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
__builder.AddContent(25, Current_Client.Postal_code);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(26, "\n                        ");
            __builder.OpenElement(27, "td");
#nullable restore
#line 40 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
__builder.AddContent(28, Current_Client.Email);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\n                        ");
            __builder.OpenElement(30, "td");
#nullable restore
#line 41 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
__builder.AddContent(31, Current_Client.Phone_Number);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenElement(33, "button");
            __builder.AddAttribute(34, "class", "btn btn-primary");
            __builder.AddAttribute(35, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 42 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                                                                  () => EditRedirect(Current_Client.Username,Current_Client.Address,Current_Client.Postal_code,Current_Client.Email,Current_Client.Phone_Number,Current_Client.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(36);
            __builder.AddAttribute(37, "Text", "Edit Row");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<i class=\"oi oi-pencil\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                        ");
            __builder.OpenElement(41, "button");
            __builder.AddAttribute(42, "type", "button");
            __builder.AddAttribute(43, "class", "btn btn-danger");
            __builder.AddAttribute(44, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                                                                               () => DeleteClient(Current_Client.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(45);
            __builder.AddAttribute(46, "Text", "Delete");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<i class=\"oi oi-trash\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
                      
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
#line 66 "/Users/yassa/TikTechCRM/Pages/Clients.razor"
      
    private List<ClientModel> ClientData = new();
    public Validate Validate;
    protected override async Task OnInitializedAsync(){
        dynamic validate;
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       if(value==null){
            NavManager.NavigateTo("/",true); 
       }
        using var client = new HttpClient();
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Clients/all_Clients");

        JArray data = JArray.Parse(result);
        foreach (dynamic obj in data){
                ClientData.Add(new ClientModel(){
                    Address = obj.Address,
                    Deleted  = obj.Deleted,
                    Email = obj.Email,
                    Id = obj.Id,
                    Phone_Number = obj.Phone_Number,
                    Postal_code = obj.Postal_code,
                    Username = obj.Username
            });
        }
       
        StateHasChanged();
    }
        private void Redirect()
    {
        NavManager.NavigateTo("/newclient",true); 
    }
    private async void DeleteClient(int id){
        using var client = new HttpClient();
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Clients/del_Client/"+id.ToString());
        NavManager.NavigateTo("/Clients",true); 

    }
    private void EditRedirect(string Username, string Address, string Postal_code, string Email, string Phone_number, int id){
        NavManager.NavigateTo("/EditClient/"+Username+"/"+Address+"/"+Postal_code+"/"+Email+"/"+Phone_number+"/"+id.ToString());
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
