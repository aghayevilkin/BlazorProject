#pragma checksum "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "98e17b391de1ecc7d6848a4972640fd0df89deb5"
// <auto-generated/>
#pragma warning disable 1591
namespace HiddenVilla_Server.Pages.HotelRoom
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/create")]
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel-room/edit/{Id:int}")]
    public partial class HotelRoomUpsert : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "row mt-2 mb-5");
            __builder.OpenElement(2, "h3");
            __builder.AddAttribute(3, "class", "card-title text-info mb-3 ml-3");
            __builder.AddContent(4, 
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                Title

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(5, " Hotel Room");
            __builder.CloseElement();
            __builder.AddMarkupContent(6, "\r\n    ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "col-md-12");
            __builder.OpenElement(9, "div");
            __builder.AddAttribute(10, "class", "card");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(13);
            __builder.AddAttribute(14, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                 HotelRoomModel

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(15, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                HandleHotelRoomUpsert

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(16, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(17);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(18, "\r\n                    ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(19);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(20, "\r\n                    ");
                __builder2.OpenElement(21, "div");
                __builder2.AddAttribute(22, "class", "form-group");
                __builder2.AddMarkupContent(23, "<label>Name</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(24);
                __builder2.AddAttribute(25, "class", "form-control");
                __builder2.AddAttribute(26, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 20 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Name = __value, HotelRoomModel.Name))));
                __builder2.AddAttribute(28, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.Name));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_0(__builder2, 30, 31, 
#nullable restore
#line 21 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(32, "\r\n                    ");
                __builder2.OpenElement(33, "div");
                __builder2.AddAttribute(34, "class", "form-group");
                __builder2.AddMarkupContent(35, "<label>Occupancy</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_1(__builder2, 36, 37, "form-control", 38, 
#nullable restore
#line 25 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                , 39, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.Occupancy = __value, HotelRoomModel.Occupancy)), 40, () => HotelRoomModel.Occupancy);
                __builder2.AddMarkupContent(41, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_2(__builder2, 42, 43, 
#nullable restore
#line 26 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.Occupancy

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(44, "\r\n                    ");
                __builder2.OpenElement(45, "div");
                __builder2.AddAttribute(46, "class", "form-group");
                __builder2.AddMarkupContent(47, "<label>Rate</label>\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateInputNumber_3(__builder2, 48, 49, "form-control", 50, 
#nullable restore
#line 30 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                  HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                , 51, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.RegularRate = __value, HotelRoomModel.RegularRate)), 52, () => HotelRoomModel.RegularRate);
                __builder2.AddMarkupContent(53, "\r\n                        ");
                __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert.TypeInference.CreateValidationMessage_4(__builder2, 54, 55, 
#nullable restore
#line 31 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                ()=>HotelRoomModel.RegularRate

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(56, "\r\n                    ");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group");
                __builder2.AddMarkupContent(59, "<label>Sq Ft</label>\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(60);
                __builder2.AddAttribute(61, "class", "form-control");
                __builder2.AddAttribute(62, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 35 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                HotelRoomModel.SqFt

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(63, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => HotelRoomModel.SqFt = __value, HotelRoomModel.SqFt))));
                __builder2.AddAttribute(64, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => HotelRoomModel.SqFt));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(65, "\r\n                    ");
                __builder2.OpenElement(66, "div");
                __builder2.AddAttribute(67, "class", "form-group");
                __builder2.AddAttribute(68, "style", "height:250px;");
                __builder2.AddMarkupContent(69, "<label>Details</label>\r\n\r\n                        ");
                __builder2.OpenComponent<Blazored.TextEditor.BlazoredTextEditor>(70);
                __builder2.AddAttribute(71, "Placeholder", "Please enter room details");
                __builder2.AddAttribute(72, "ToolbarContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.OpenElement(73, "select");
                    __builder3.AddAttribute(74, "class", "ql-header");
                    __builder3.OpenElement(75, "option");
                    __builder3.AddAttribute(76, "selected");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(77, "\r\n                                    ");
                    __builder3.OpenElement(78, "option");
                    __builder3.AddAttribute(79, "value", "1");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(80, "\r\n                                    ");
                    __builder3.OpenElement(81, "option");
                    __builder3.AddAttribute(82, "value", "2");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(83, "\r\n                                    ");
                    __builder3.OpenElement(84, "option");
                    __builder3.AddAttribute(85, "value", "3");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(86, "\r\n                                    ");
                    __builder3.OpenElement(87, "option");
                    __builder3.AddAttribute(88, "value", "4");
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(89, "\r\n                                    ");
                    __builder3.OpenElement(90, "option");
                    __builder3.AddAttribute(91, "value", "5");
                    __builder3.CloseElement();
                    __builder3.CloseElement();
                    __builder3.AddMarkupContent(92, "\r\n                                ");
                    __builder3.AddMarkupContent(93, @"<span class=""ql-formats""><button class=""ql-bold""></button>
                                    <button class=""ql-italic""></button>
                                    <button class=""ql-underline""></button>
                                    <button class=""ql-strike""></button></span>
                                ");
                    __builder3.AddMarkupContent(94, "<span class=\"ql-formats\"><select class=\"ql-color\"></select>\r\n                                    <select class=\"ql-background\"></select></span>\r\n                                ");
                    __builder3.AddMarkupContent(95, "<span class=\"ql-formats\"><button class=\"ql-list\" value=\"ordered\"></button>\r\n                                    <button class=\"ql-list\" value=\"bullet\"></button></span>\r\n                                ");
                    __builder3.AddMarkupContent(96, "<span class=\"ql-formats\"><button class=\"ql-link\"></button></span>");
                }
                ));
                __builder2.AddAttribute(97, "EditorContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                }
                ));
                __builder2.AddComponentReferenceCapture(98, (__value) => {
#nullable restore
#line 41 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                   QuillHtml = (Blazored.TextEditor.BlazoredTextEditor)__value;

#line default
#line hidden
#nullable disable
                }
                );
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(99, "\r\n                    ");
                __builder2.OpenElement(100, "div");
                __builder2.AddAttribute(101, "class", "form-group");
                __builder2.AddAttribute(102, "style", "padding-top: 100px; padding-bottom: 20px;");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputFile>(103);
                __builder2.AddAttribute(104, "OnChange", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.InputFileChangeEventArgs>(this, 
#nullable restore
#line 76 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                             HandleImageUpload

#line default
#line hidden
#nullable disable
                )));
                __builder2.AddAttribute(105, "multiple", true);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(106, "\r\n                        ");
                __builder2.OpenElement(107, "div");
                __builder2.AddAttribute(108, "class", "row");
#nullable restore
#line 78 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                             if (IsImageUploadProcessStarted)
                            {

#line default
#line hidden
#nullable disable
                __builder2.AddMarkupContent(109, "<div class=\"col-md-12\"><span><i class=\"fa fa-spin fa-spinner\"></i> Please wait.. Images are uploading...</span></div>");
#nullable restore
#line 83 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 84 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                             if (HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Count > 0)
                            {
                                int serial = 1;
                                foreach (var roomImage in HotelRoomModel.ImageUrls)
                                {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(110, "div");
                __builder2.AddAttribute(111, "class", "col-md-2 mt-3");
                __builder2.OpenElement(112, "div");
                __builder2.AddAttribute(113, "class", "room-image");
                __builder2.AddAttribute(114, "style", "background:" + " url(\'" + (
#nullable restore
#line 90 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                                         roomImage

#line default
#line hidden
#nullable disable
                ) + "\')" + " 50%" + " 50%" + " ");
                __builder2.OpenElement(115, "span");
                __builder2.AddAttribute(116, "class", "room-image-title");
                __builder2.AddContent(117, 
#nullable restore
#line 91 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                            serial

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(118, "\r\n                                        ");
                __builder2.OpenElement(119, "button");
                __builder2.AddAttribute(120, "type", "button");
                __builder2.AddAttribute(121, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 93 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                                        ()=>DeletePhoto(roomImage)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(122, "class", "btn btn-outline-danger btn-block mt-4");
                __builder2.AddContent(123, " Delete");
                __builder2.CloseElement();
                __builder2.CloseElement();
#nullable restore
#line 95 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"

                                    serial++;
                                }
                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(124, "\r\n                    ");
                __builder2.OpenElement(125, "div");
                __builder2.AddAttribute(126, "class", "form-group");
                __builder2.OpenElement(127, "button");
                __builder2.AddAttribute(128, "class", "btn btn-primary");
                __builder2.AddContent(129, 
#nullable restore
#line 102 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
                                                         Title

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(130, " Room");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(131, "\r\n                        ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(132);
                __builder2.AddAttribute(133, "href", "hotel-room");
                __builder2.AddAttribute(134, "class", "btn btn-secondary");
                __builder2.AddAttribute(135, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder3) => {
                    __builder3.AddContent(136, "Back to Index");
                }
                ));
                __builder2.CloseComponent();
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 111 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Server\Pages\HotelRoom\HotelRoomUpsert.razor"
       

    [Parameter]
    public int? Id { get; set; }

    private HotelRoomDTO HotelRoomModel { get; set; } = new HotelRoomDTO();
    private string Title { get; set; } = "Create";
    private HotelRoomImageDTO RoomImage { get; set; } = new HotelRoomImageDTO();
    private List<string> DeletedImageNames { get; set; } = new List<string>();
    public BlazoredTextEditor QuillHtml { get; set; } = new BlazoredTextEditor();

    private bool IsImageUploadProcessStarted { get; set; } = false;

    [CascadingParameter]
    public Task<AuthenticationState> AuthenticationState { get; set; }


    protected override async Task OnInitializedAsync()
    {
        var authenticationState = await AuthenticationState;
        if (!authenticationState.User.IsInRole(SD.Role_Admin))
        {
            var uri = new Uri(NavigationManager.Uri);
            NavigationManager.NavigateTo($"/identity/account/login?returnUrl={uri.LocalPath}");
        }

        if (Id != null)
        {
            //Updating
            Title = "Update";
            HotelRoomModel = await HotelRoomRepository.GetHotelRoom(Id.Value);

            if (HotelRoomModel?.HotelRoomImages != null)
            {
                HotelRoomModel.ImageUrls = HotelRoomModel.HotelRoomImages.Select(u => u.RoomImageUrl).ToList();
            }

        }
        else
        {
            //Create
            HotelRoomModel = new HotelRoomDTO();
        }
    }

    protected override async Task OnAfterRenderAsync(bool firstRender)
    {
        if (!firstRender)
            return;
        bool loading = true;
        while (loading)
        {
            try
            {
                if (!string.IsNullOrEmpty(HotelRoomModel.Details))
                {
                    await this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
                }
                loading = false;
            }
            catch (Exception)
            {
                await Task.Delay(10);
                loading = true;
            }
        }

    }


    private async Task HandleHotelRoomUpsert()
    {

        try
        {
            var roomDetailsByName = await HotelRoomRepository.IsRoomUnique(HotelRoomModel.Name, HotelRoomModel.Id);
            if (roomDetailsByName != null)
            {
                await JsRuntime.ToastrError("Room name already exists.");
                return;
            }

            if (HotelRoomModel.Id != 0 && Title == "Update")
            {
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                //Update
                var updateRoomResult = await HotelRoomRepository.UpdateHotelRoom(HotelRoomModel.Id, HotelRoomModel);
                if ((HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    || (DeletedImageNames != null && DeletedImageNames.Any())
                    )
                {
                    if (DeletedImageNames != null && DeletedImageNames.Any())
                    {
                        foreach (var deletedImageName in DeletedImageNames)
                        {
                            var imageName = deletedImageName.Replace($"{NavigationManager.BaseUri}RoomImages/", "");

                            var result = FileUpload.DeleteFile(imageName);
                            await HotelImagesRepository.DeleteHotelRoomImageByUrl(deletedImageName);
                        }
                    }



                    await AddHotelRoomImage(updateRoomResult);
                }
                await JsRuntime.ToastrSuccess("Hotel room updated successfully.");
            }
            else
            {
                //Create
                HotelRoomModel.Details = await QuillHtml.GetHTML();
                var createdResult = await HotelRoomRepository.CreateHotelRoom(HotelRoomModel);
                await AddHotelRoomImage(createdResult);
                await JsRuntime.ToastrSuccess("Hotel room created successfully.");
            }
        }
        catch (Exception ex)
        {
            //log exceptions
            throw;
        }



        NavigationManager.NavigateTo("hotel-room");
    }

    //public void SetHtml()
    //{
    //    if (!string.IsNullOrEmpty(HotelRoomModel.Details))
    //    {
    //        this.QuillHtml.LoadHTMLContent(HotelRoomModel.Details);
    //    }
    //    StateHasChanged();
    //}

    private async Task HandleImageUpload(InputFileChangeEventArgs e)
    {
        IsImageUploadProcessStarted = true;

        try
        {
            var images = new List<string>();
            if (e.GetMultipleFiles().Count > 0)
            {
                foreach (var file in e.GetMultipleFiles())
                {
                    System.IO.FileInfo fileInfo = new System.IO.FileInfo(file.Name);
                    if (fileInfo.Extension.ToLower() == ".jpg" ||
                        fileInfo.Extension.ToLower() == ".png" ||
                        fileInfo.Extension.ToLower() == ".jpeg")
                    {
                        var uploadedImagePath = await FileUpload.UploadFile(file);
                        images.Add(uploadedImagePath);
                    }
                    else
                    {
                        await JsRuntime.ToastrError("Please select .jpg/ .jpeg/ .png file only");
                        return;
                    }
                }

                if (images.Any())
                {
                    if (HotelRoomModel.ImageUrls != null && HotelRoomModel.ImageUrls.Any())
                    {
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                    else
                    {
                        HotelRoomModel.ImageUrls = new List<string>();
                        HotelRoomModel.ImageUrls.AddRange(images);
                    }
                }
                else
                {
                    await JsRuntime.ToastrError("Image uploading failed");
                    return;
                }
            }
            IsImageUploadProcessStarted = false;
        }
        catch (Exception ex)
        {

            await JsRuntime.ToastrError(ex.Message);
        }

    }


    private async Task AddHotelRoomImage(HotelRoomDTO roomDetails)
    {
        foreach (var imageUrl in HotelRoomModel.ImageUrls)
        {
            if (HotelRoomModel.HotelRoomImages == null || HotelRoomModel.HotelRoomImages.Where(x => x.RoomImageUrl == imageUrl).Count() == 0)
            {
                RoomImage = new HotelRoomImageDTO()
                {
                    RoomId = roomDetails.Id,
                    RoomImageUrl = imageUrl,
                };
                await HotelImagesRepository.CreateHotelRoomImage(RoomImage);
            }

        }
    }


    internal async Task DeletePhoto(string imageUrl)
    {
        try
        {
            var imageIndex = HotelRoomModel.ImageUrls.FindIndex(x => x == imageUrl);
            var imageName = imageUrl.Replace($"{NavigationManager.BaseUri}RoomImages/", "");
            if (HotelRoomModel.Id == 0 && Title == "Create")
            {
                var result = FileUpload.DeleteFile(imageName);
            }
            else
            {
                //Update
                DeletedImageNames ??= new List<string>();
                DeletedImageNames.Add(imageUrl);
            }

            HotelRoomModel.ImageUrls.RemoveAt(imageIndex);
        }
        catch (Exception ex)
        {

            await JsRuntime.ToastrError(ex.Message);
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IFileUpload FileUpload { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelImagesRepository HotelImagesRepository { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomRepository HotelRoomRepository { get; set; }
    }
}
namespace __Blazor.HiddenVilla_Server.Pages.HotelRoom.HotelRoomUpsert
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateValidationMessage_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_1<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_2<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
        public static void CreateInputNumber_3<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, TValue __arg1, int __seq2, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg2, int __seq3, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg3)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputNumber<TValue>>(seq);
        __builder.AddAttribute(__seq0, "class", __arg0);
        __builder.AddAttribute(__seq1, "Value", __arg1);
        __builder.AddAttribute(__seq2, "ValueChanged", __arg2);
        __builder.AddAttribute(__seq3, "ValueExpression", __arg3);
        __builder.CloseComponent();
        }
        public static void CreateValidationMessage_4<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg0)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.ValidationMessage<TValue>>(seq);
        __builder.AddAttribute(__seq0, "For", __arg0);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
