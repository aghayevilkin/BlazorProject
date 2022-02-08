#pragma checksum "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11446407c892dcb39d4a3d3ef8d451033e11fce8"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.LearnBlazor
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business.Repository.IRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Helper;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/blazorjs")]
    public partial class BlazorJS : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>BlazorJS</h3>\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "row");
            __builder.OpenElement(3, "button");
            __builder.AddAttribute(4, "class", "btn btn-secondary");
            __builder.AddAttribute(5, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                                (()=>TestConfirmBox(ConfirmMessage))

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(6, "Test Confirm Button");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\r\n");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "row mt-4");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-success");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                              TestSuccess

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Test Toastr Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "button");
            __builder.AddAttribute(16, "class", "btn btn-danger");
            __builder.AddAttribute(17, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                             TestFailure

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(18, "Test Toastr Failure");
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n    ");
            __builder.OpenElement(20, "button");
            __builder.AddAttribute(21, "class", "btn btn-info");
            __builder.AddAttribute(22, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                           TestInfo

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(23, "Test Toastr Info");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n    ");
            __builder.OpenElement(25, "button");
            __builder.AddAttribute(26, "class", "btn btn-warning");
            __builder.AddAttribute(27, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                              TestWarning

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(28, "Test Toastr Warning");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n");
            __builder.OpenElement(30, "div");
            __builder.AddAttribute(31, "class", "row mt-4");
            __builder.OpenElement(32, "button");
            __builder.AddAttribute(33, "class", "btn btn-success");
            __builder.AddAttribute(34, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                              TestSuccessSwal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(35, "Test Swal Success");
            __builder.CloseElement();
            __builder.AddMarkupContent(36, "\r\n    ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
                                             TestFailureSwal

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Test Swal Failure");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n");
            __builder.OpenElement(42, "div");
            __builder.AddAttribute(43, "class", "row");
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
     if (ConfirmResult)
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(44, "<p>Confirmation has been made!</p>");
#nullable restore
#line 23 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
    }
    else
    {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(45, "<p>Confirmation Pending</p>");
#nullable restore
#line 27 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\BlazorJS.razor"
       
    private string ConfirmMessage = "Are you sure you want to click?";
    private bool ConfirmResult { get; set; }

    private async Task TestConfirmBox(string message)
    {
        ConfirmResult = await JsRuntime.InvokeAsync<bool>("confirm", message);
    }

    private async Task TestSuccess()
    {
        await JsRuntime.ToastrSuccess("Success Message");
    }

    private async Task TestFailure()
    {
        await JsRuntime.ToastrError("Error Mesage");
    }

    private async Task TestInfo()
    {
        await JsRuntime.ToastrInfo("Info Mesage");
    }

    private async Task TestWarning()
    {
        await JsRuntime.ToastrWarning("Warning Mesage");
    }




    private async Task TestSuccessSwal()
    {
        await JsRuntime.InvokeVoidAsync("ShowSwal","success", "Task completed succesfuly!");
    }

    private async Task TestFailureSwal()
    {
        await JsRuntime.InvokeVoidAsync("ShowSwal", "error", "Task Failed!");
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
    }
}
#pragma warning restore 1591
