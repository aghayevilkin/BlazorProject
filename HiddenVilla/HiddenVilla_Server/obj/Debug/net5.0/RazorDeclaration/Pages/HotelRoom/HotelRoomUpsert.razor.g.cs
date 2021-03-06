// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
#pragma warning restore 1591
