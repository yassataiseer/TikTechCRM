#pragma checksum "/Users/yassa/TikTechCRM/Pages/Inventory.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4c286ab0e6e5683d7fd14002c17c9f5b229458a"
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
#line 65 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 66 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Text;

#line default
#line hidden
#nullable disable
#nullable restore
#line 67 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using System.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 69 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
using Newtonsoft.Json.Linq;

#line default
#line hidden
#nullable disable
#nullable restore
#line 70 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
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
            __builder.AddMarkupContent(1, @"<div id=""app"" style=""margin: 0 auto; width: 100vw; height: 100vh""><div class=""text-center pt-3"" style=""color: rgb(5, 39, 103); font-size: 16pt"">
          Loading...
        </div>
        <div class=""text-center mt-3""><span class=""spinner-border spinner-border-sm"" role=""status"" aria-hidden=""true"" style=""font-size: 16pt; width: 36px; height: 36px; color: rgb(5, 39, 103)""></span></div>
        <div class=""text-center""></div></div>");
#nullable restore
#line 17 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
}else{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<h1>Inventory</h1>\n    <br>\n    ");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-info");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 20 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                            () => Redirect()

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(6);
            __builder.AddAttribute(7, "Text", "Add To Inventory");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(9, "<i class=\"oi oi-plus\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.AddContent(10, " Inventory");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, " \n    <br>\n    ");
            __builder.OpenElement(12, "table");
            __builder.AddAttribute(13, "class", "table");
            __builder.AddMarkupContent(14, "<thead><tr><th>Item</th>\n                <th>Barcode</th>\n                <th>Price</th>\n                <th>Quantity</th>\n                <th>Status</th></tr></thead>\n        ");
            __builder.OpenElement(15, "tbody");
#nullable restore
#line 34 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                 foreach (var Current_Inventory in InventoryData)
                {
                string Color = "#ff9e9e";


#line default
#line hidden
#nullable disable
            __builder.OpenElement(16, "tr");
#nullable restore
#line 40 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                          if(Current_Inventory.Quantity>0){
                             Color = "#adffc3";
                         }

#line default
#line hidden
#nullable disable
            __builder.OpenElement(17, "td");
            __builder.AddAttribute(18, "bgcolor", 
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                     Color

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 45 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
__builder.AddContent(19, Current_Inventory.Item);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\n                        ");
            __builder.OpenElement(21, "td");
            __builder.AddAttribute(22, "bgcolor", 
#nullable restore
#line 46 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                     Color

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 46 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
__builder.AddContent(23, Current_Inventory.Barcode);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n                        ");
            __builder.OpenElement(25, "td");
            __builder.AddAttribute(26, "bgcolor", 
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                     Color

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 47 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
__builder.AddContent(27, Current_Inventory.Price);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\n                        ");
            __builder.OpenElement(29, "td");
            __builder.AddAttribute(30, "bgcolor", 
#nullable restore
#line 48 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                     Color

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 48 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
__builder.AddContent(31, Current_Inventory.Quantity);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\n                        ");
            __builder.OpenElement(33, "td");
            __builder.AddAttribute(34, "bgcolor", 
#nullable restore
#line 49 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                     Color

#line default
#line hidden
#nullable disable
            );
#nullable restore
#line 49 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
__builder.AddContent(35, Current_Inventory.Status);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\n\n                        <br>\n                         \n\n                        ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-primary");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 54 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                                                  () => EditRedirect(Current_Inventory.Item,Current_Inventory.Barcode,Current_Inventory.Price,Current_Inventory.Quantity,Current_Inventory.Status)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(40);
            __builder.AddAttribute(41, "Text", "Edit Row");
            __builder.AddAttribute(42, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(43, "<i class=\"oi oi-pencil\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(44, "\n                        ");
            __builder.OpenElement(45, "button");
            __builder.AddAttribute(46, "type", "button");
            __builder.AddAttribute(47, "class", "btn btn-danger");
            __builder.AddAttribute(48, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 55 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                                                                               () => DeleteInventory(Current_Inventory.Item)

#line default
#line hidden
#nullable disable
            ));
            __builder.OpenComponent<TikTechCRM.Shared.Tooltip>(49);
            __builder.AddAttribute(50, "Text", "Delete");
            __builder.AddAttribute(51, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(52, "<i class=\"oi oi-trash\"></i>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 57 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 60 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"


}

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 75 "/Users/yassa/TikTechCRM/Pages/Inventory.razor"
      
    private dynamic validate;
    private List<InventoryModel> InventoryData = new();


    protected override async Task OnInitializedAsync(){
        validate =  await JsRuntime.InvokeAsync<string>("BlazorGetLocalStorage","Username:");
       string value = (string)validate;
       if(value==null){
            NavManager.NavigateTo("/",true); 
       }
        using var client = new HttpClient();
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Inventory/grab_Inventory");

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
        var result = await client.GetStringAsync("https://ticktechapi.pythonanywhere.com/Inventory/del_Inventory/"+Item);
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
