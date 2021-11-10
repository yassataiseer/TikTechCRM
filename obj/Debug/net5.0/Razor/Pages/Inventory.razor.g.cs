#pragma checksum "/Users/yassa/TikTechCRM/Pages/Inventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b55e74c271a431ea0bc0bacfc817b6ce783e263"
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
#line 55 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 57 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 58 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 59 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/inventory")]
    public partial class Inventory : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
#nullable restore
#line 5 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
 if (InventoryData == null){

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 7 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h1>Inventory</h1>\n    <br>\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-info");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                            () => Redirect()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(6, "<i class=\"oi oi-plus\"></i> Inventory");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, " \n    <br>\n    ");
            __builder.OpenElement(8, "table");
            __builder.AddAttribute(9, "class", "table");
            __builder.AddMarkupContent(10, "<thead><tr><th>Item</th>\n                <th>Barcode</th>\n                <th>Price</th>\n                <th>Quantity</th>\n                <th>Status</th></tr></thead>\n        ");
            __builder.OpenElement(11, "tbody");
#nullable restore
#line 24 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                 foreach (var Current_Inventory in InventoryData)
                {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(12, "tr");
#nullable restore
#line 27 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                          if(Current_Inventory.Quantity>0){

#line default
#line hidden
#nullable disable
            __builder.OpenElement(13, "td");
            __builder.AddAttribute(14, "bgcolor", "#adffc3");
            __builder.AddContent(15, 
#nullable restore
#line 28 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n                        ");
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "bgcolor", "#adffc3");
            __builder.AddContent(19, 
#nullable restore
#line 29 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Barcode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "bgcolor", "#adffc3");
            __builder.AddContent(23, 
#nullable restore
#line 30 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "bgcolor", "#adffc3");
            __builder.AddContent(27, 
#nullable restore
#line 31 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "bgcolor", "#adffc3");
            __builder.AddContent(31, 
#nullable restore
#line 32 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "<br>");
#nullable restore
#line 35 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                         }
                         else{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "bgcolor", "#ff9e9e");
            __builder.AddContent(35, 
#nullable restore
#line 37 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Item

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n                        ");
            __builder.OpenElement(37, "td");
            __builder.AddAttribute(38, "bgcolor", "#ff9e9e");
            __builder.AddContent(39, 
#nullable restore
#line 38 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Barcode

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(40, "\n                        ");
            __builder.OpenElement(41, "td");
            __builder.AddAttribute(42, "bgcolor", "#ff9e9e");
            __builder.AddContent(43, 
#nullable restore
#line 39 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Price

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.OpenElement(45, "td");
            __builder.AddAttribute(46, "bgcolor", "#ff9e9e");
            __builder.AddContent(47, 
#nullable restore
#line 40 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Quantity

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(48, "\n                        ");
            __builder.OpenElement(49, "td");
            __builder.AddAttribute(50, "bgcolor", "#ff9e9e");
            __builder.AddContent(51, 
#nullable restore
#line 41 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                               Current_Inventory.Status

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(52, "\n                        <br>");
#nullable restore
#line 43 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                         }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(53, "button");
            __builder.AddAttribute(54, "class", "btn btn-primary");
            __builder.AddAttribute(55, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 44 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                                                  () => EditRedirect(Current_Inventory.Item,Current_Inventory.Barcode,Current_Inventory.Price,Current_Inventory.Quantity,Current_Inventory.Status)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(56, "<i class=\"oi oi-pencil\"></i>");
            __builder.CloseElement();
            __builder.AddMarkupContent(57, "\n                        ");
            __builder.OpenElement(58, "button");
            __builder.AddAttribute(59, "type", "button");
            __builder.AddAttribute(60, "class", "btn btn-danger");
            __builder.AddAttribute(61, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                                                               () => DeleteInventory(Current_Inventory.Item)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(62, "<i class=\"oi oi-trash\"></i>");
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 50 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"


}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 65 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
      
    private dynamic validate;
    private List<InventoryModel> InventoryData = new();


    protected override async Task OnInitializedAsync(){
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       if(value==null){
            NavManager.NavigateTo("/",true); 
       }
        using var client = new HttpClient();
        var result = await client.GetStringAsync("http://0.0.0.0:800/Inventory/grab_Inventory");

        JArray data = JArray.Parse(result);
        foreach (dynamic obj in data){
                InventoryData.Add(new InventoryModel(){
                    Barcode = obj.Barcode,
                    Item  = obj.Item,
                    Price = obj.Price,
                    Quantity = obj.Quantity,
                    Status = obj.Status
            });
        }
        StateHasChanged();
    }
    private async void DeleteInventory(string Item){
        using var client = new HttpClient();
        var result = await client.GetStringAsync("http://0.0.0.0:800/Inventory/del_Inventory/"+Item);
        NavManager.NavigateTo("/inventory",true); 
    }
    void Redirect(){
        NavManager.NavigateTo("/newinventory",true); 
    }
    private void EditRedirect(string Item,string Barcode, double Price, int Quantity, string Status)
    {
        NavManager.NavigateTo("/editinventory/"+Item+"/"+Barcode+"/"+Price.ToString("0.00")+"/"+Quantity.ToString()+"/"+Status,true); 
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager UriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService Modal { get; set; }
    }
}
#pragma warning restore 1591
