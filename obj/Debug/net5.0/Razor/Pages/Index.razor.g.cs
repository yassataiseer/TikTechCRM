#pragma checksum "/Users/yassa/TikTechCRM/Pages/Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fc80f7eac16cf4c0d47afc2d8e31cf0f758a4102"
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
#line 1 "/Users/yassa/TikTechCRM/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/yassa/TikTechCRM/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Users")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "html");
            __builder.AddMarkupContent(1, "<h1>Users</h1>\r\n\r\n    ");
            __builder.AddMarkupContent(2, @"<table class=""table""><thead><tr><th>Name</th>
                <th>Password</th></tr></thead>
        <tbody><tr><td>Yassa Taiseer</td>
                    <td>yassa123 <button class=""btn btn-primary"">Edit</button>
                    <button type=""button"" class=""btn btn-danger"">Delete</button></td></tr></tbody></table>
");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 23 "/Users/yassa/TikTechCRM/Pages/Index.razor"
                    ()=>modal.Show<FetchData>("Modal Popup Example")

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(5, "class", "btn btn-primary");
            __builder.AddContent(6, "View");
            __builder.CloseElement();
            __builder.AddMarkupContent(7, " \r\n");
            __builder.AddMarkupContent(8, "<button class=\"btn btn-info\">Add a User</button>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IModalService modal { get; set; }
    }
}
#pragma warning restore 1591
