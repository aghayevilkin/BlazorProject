#pragma checksum "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2495a1b0b8cbddeb1d1dffa64d9208f3ccee25ef"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/parentcomponent")]
    public partial class ParentComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 class=\"text-danger\">Parent Child Component</h1>\r\n");
            __Blazor.HiddenVilla_Server.Pages.LearnBlazor.ParentComponent.TypeInference.CreateCascadingValue_0(__builder, 1, 2, 
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                        messageForGrandChild

#line default
#line hidden
#nullable disable
            , 3, "MessageFromGrandParent", 4, (__builder2) => {
                __Blazor.HiddenVilla_Server.Pages.LearnBlazor.ParentComponent.TypeInference.CreateCascadingValue_1(__builder2, 5, 6, 
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                           LuckyNumber

#line default
#line hidden
#nullable disable
                , 7, "GrandParentsLuckyNumber", 8, (__builder3) => {
                    __builder3.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.ChildComponent>(9);
                    __builder3.AddAttribute(10, "OnClickBtnMethod", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Web.MouseEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                                                           ShowMessage

#line default
#line hidden
#nullable disable
                    )));
                    __builder3.AddAttribute(11, "Title", "This title is passed as parameter from Parent Component");
                    __builder3.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(13, "Render Fragement Parent! WooHOO!");
                    }
                    ));
                    __builder3.AddAttribute(14, "DangerChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder4) => {
                        __builder4.AddContent(15, "Danger Content from Render Fragemen! WooHOO!");
                    }
                    ));
                    __builder3.AddComponentReferenceCapture(16, (__value) => {
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                              childComp = (HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.ChildComponent)__value;

#line default
#line hidden
#nullable disable
                    }
                    );
                    __builder3.CloseComponent();
                }
                );
            }
            );
            __builder.AddMarkupContent(17, "\r\n");
            __builder.OpenElement(18, "p");
            __builder.OpenElement(19, "b");
            __builder.AddContent(20, 
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
       messageText

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Pages.LearnBlazor.LearnBlazorComponent.AnotherChildComponent>(22);
            __builder.AddAttribute(23, "placeholder", "Placeholder Default");
            __builder.CloseComponent();
            __builder.AddMarkupContent(24, "\r\n\r\n");
            __builder.OpenElement(25, "div");
            __builder.AddAttribute(26, "class", "row mt-2");
            __builder.OpenElement(27, "button");
            __builder.AddAttribute(28, "class", "btn btn-success");
            __builder.AddAttribute(29, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 22 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
                                              ()=>childComp.ShowToastrSuccess()

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(30, "Show Alert");
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\LearnBlazor\ParentComponent.razor"
       

    //[Parameter]
    //public Dictionary<string, object> InputAttributesFromParent { get; set; } = new Dictionary<string, object>()
    //{
    //    { "required" , "required"},
    //    { "placeholder" , "Enter the Room Name from Parent"},
    //    { "maxlength", 5 },
    //};

    private ChildComponent childComp;

    private string messageForGrandChild = "This is a message Grand Parent";
    public string LuckyNumber { get; set; } = "7";

    private string messageText = "";

    private void ShowMessage(MouseEventArgs e)
    {
        messageText = "Blazzing text from parent";
    }

#line default
#line hidden
#nullable disable
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.LearnBlazor.ParentComponent
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateCascadingValue_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
        public static void CreateCascadingValue_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, TValue __arg0, int __seq1, global::System.String __arg1, int __seq2, global::Microsoft.AspNetCore.Components.RenderFragment __arg2)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.CascadingValue<TValue>>(seq);
        __builder.AddAttribute(__seq0, "Value", __arg0);
        __builder.AddAttribute(__seq1, "Name", __arg1);
        __builder.AddAttribute(__seq2, "ChildContent", __arg2);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
