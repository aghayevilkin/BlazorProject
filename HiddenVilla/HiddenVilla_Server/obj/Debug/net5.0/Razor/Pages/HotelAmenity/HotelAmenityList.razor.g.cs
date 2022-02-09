#pragma checksum "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c136ee44cfb312e99369f5218f6cb50ee1c46923"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelAmenity
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotelamenity")]
    public partial class HotelAmenityList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-4");
            __builder.AddMarkupContent(2, "<div class=\"col-8\"><h4 class=\"card-title text-info\">Hotel Amenity</h4></div>\r\n    ");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "col-3 offset-1");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "hotelamenity/create");
            __builder.AddAttribute(7, "class", "btn btn-info form-control");
            __builder.AddAttribute(8, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(9, "Add New Room");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "row mt-4");
            __builder.OpenElement(13, "div");
            __builder.AddAttribute(14, "class", "col-12");
            __builder.OpenElement(15, "table");
            __builder.AddAttribute(16, "class", "table table-bordered table-hover");
            __builder.AddMarkupContent(17, "<thead><tr><th>Name</th>\r\n                    <th>Timming</th>\r\n                    <th>Icon</th>\r\n                    <th></th></tr></thead>\r\n            ");
            __builder.OpenElement(18, "tbody");
#nullable restore
#line 28 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                 if (HotelAmenities.Any())
                {
                    foreach (var item in HotelAmenities)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(19, "tr");
            __builder.OpenElement(20, "td");
            __builder.AddContent(21, 
#nullable restore
#line 33 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                 item.Name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n                            ");
            __builder.OpenElement(23, "td");
            __builder.AddContent(24, 
#nullable restore
#line 34 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                 item.Timming

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                            ");
            __builder.OpenElement(26, "td");
            __builder.OpenElement(27, "i");
            __builder.AddAttribute(28, "class", 
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                           item.Icon

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                            ");
            __builder.OpenElement(30, "td");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "href", 
#nullable restore
#line 37 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                                 $"hotelamenity/edit/{item.Id}"

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(33, "class", "btn btn-primary");
            __builder.AddAttribute(34, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(35, "Edit");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(36, "\r\n                                ");
            __builder.OpenElement(37, "button");
            __builder.AddAttribute(38, "class", "btn btn-danger");
            __builder.AddAttribute(39, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 38 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                                                         ()=>HandleDelete(item.Id)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(40, "Delete");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(41, "<tr><td colspan=\"5\">No records found</td></tr>");
#nullable restore
#line 48 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n\r\n");
            __builder.OpenComponent<HiddenVilla_Server.Shared.DeleteConfirmation>(43);
            __builder.AddAttribute(44, "IsParentComponentProcessing", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                                 IsProcessing

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "ConfirmationChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, 
#nullable restore
#line 55 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
                                                                                    ConfirmDelete_Click

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
#nullable restore
#line 58 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelAmenity\HotelAmenityList.razor"
       
    private IEnumerable<HotelAmenityDTO> HotelAmenities { get; set; } = new List<HotelAmenityDTO>();
    private int? DeleteAmenityId { get; set; } = null;
    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        HotelAmenities = await HotelAmenityRepository.GetAllHotelAmenity();
    }


    private async Task HandleDelete(int amenityId)
    {
        DeleteAmenityId = amenityId;
        await JsRuntime.InvokeVoidAsync("ShowDeleteConfirmationModal");
    }


    public async Task ConfirmDelete_Click(bool isConfirmed)
    {
        IsProcessing = true;

        if (isConfirmed && DeleteAmenityId != null)
        {
            HotelAmenityDTO hotelAmenity = await HotelAmenityRepository.GetHotelAmenity(DeleteAmenityId.Value);

            await HotelAmenityRepository.DeleteHotelAmenity(DeleteAmenityId.Value);
            await JsRuntime.ToastrSuccess("Hotel Amenity Deleted successfully");
            HotelAmenities = await HotelAmenityRepository.GetAllHotelAmenity();
        }
        await JsRuntime.InvokeVoidAsync("HideDeleteConfirmationModal");

        IsProcessing = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelAmenityRepository HotelAmenityRepository { get; set; }
    }
}
#pragma warning restore 1591
