#pragma checksum "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dce4953310f05333e1e7edfb06ebac55d7da2ef2"
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
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using HiddenVilla_Server.Service.IService;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Blazored.TextEditor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Microsoft.AspNetCore.Components.Server.ProtectedBrowserStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Radzen;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Radzen.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\_Imports.razor"
using Business.Repository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/lifecycle")]
    public partial class Lifecycle : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h3>Lifecycle</h3>\r\n\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "border");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.LifecycleComponent>(3);
            __builder.AddAttribute(4, "CountValue", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                     currentCount

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(5, "\r\n\r\n\r\n\r\n");
            __builder.OpenElement(6, "p");
            __builder.AddContent(7, "Current count: ");
            __builder.AddContent(8, 
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "button");
            __builder.AddAttribute(11, "class", "btn btn-primary");
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(13, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n<br> ");
            __builder.AddContent(15, 
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
        Count

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(16, " ");
            __builder.OpenElement(17, "button");
            __builder.AddAttribute(18, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
                                StartCountdown

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(19, "Start Countdown");
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n<hr>");
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
 foreach (var item in EventType)
{
    

#line default
#line hidden
#nullable disable
            __builder.AddContent(21, 
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
     item

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(22, "<hr>");
#nullable restore
#line 24 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 27 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\Lifecycle.razor"
       
    private int currentCount = 0;
    List<string> EventType = new List<string>();
    private int Count { get; set; } = 5;

    private void IncrementCount()
    {
        currentCount++;
    }



    protected override void OnInitialized()
    {
        EventType.Add("OnInitialized is called");
    }
    protected override async Task OnInitializedAsync()
    {
        EventType.Add("OnInitializedAsync is called");
        await Task.Delay(1000);
    }



    protected override void OnParametersSet()
    {
        EventType.Add("OnParametersSet is called");
    }
    protected override async Task OnParametersSetAsync()
    {
        EventType.Add("OnParametersSetAsync is called");
        await Task.Delay(1000);
    }



    protected override void OnAfterRender(bool firstRender)
    {
        if (firstRender)
        {
            currentCount = 111;
        }
        else
        {
            currentCount = 999;
        }

        EventType.Add("OnAfterRender is called");
    }
    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        EventType.Add("OnAfterRenderAsync is called");
        await Task.Run(null);
    }



    protected override bool ShouldRender()
    {
        EventType.Add("ShouldRender is called");
        return true;
    }

    void StartCountdown()
    {
        var timer = new Timer(TimeCallBack, null, 1000, 1000);
    }

    void TimeCallBack(object state)
    {
        if (Count > 0)
        {
            Count--;
            InvokeAsync(StateHasChanged);
        }
    }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
