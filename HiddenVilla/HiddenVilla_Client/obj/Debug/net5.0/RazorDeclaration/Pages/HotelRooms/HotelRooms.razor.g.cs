// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace HiddenVilla_Client.Pages.HotelRooms
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Model.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Blazored.LocalStorage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\_Imports.razor"
using HiddenVilla_Client.Service.IService;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/hotel/rooms")]
    public partial class HotelRooms : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 158 "C:\Users\ASUS\source\repos\HiddenVilla\HiddenVilla_Client\Pages\HotelRooms\HotelRooms.razor"
       
    private HomeVM HomeModel { get; set; } = new HomeVM();
    public IEnumerable<HotelRoomDTO> Rooms { get; set; } = new List<HotelRoomDTO>();
    private bool IsProcessing { get; set; } = false;

    protected override async Task OnInitializedAsync()
    {
        try
        {
            if (await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking) != null)
            {
                HomeModel = await localStorage.GetItemAsync<HomeVM>(SD.Local_InitialBooking);
            }
            else
            {
                HomeModel.NoOfNights = 1;
            }
            await LoadRooms();
        }
        catch (Exception e)
        {

            await jsRuntime.ToastrError(e.Message);
        }
    }


    private async Task LoadRooms()
    {
        Rooms = await hotelRoomService.GetHotelRooms(HomeModel.StartDate.ToString("MM/dd/yyyy"), HomeModel.EndDate.ToString("MM/dd/yyyy"));

        foreach (var room in Rooms)
        {
            room.TotalAmount = room.RegularRate * HomeModel.NoOfNights;
            room.TotalDays = HomeModel.NoOfNights;
        }
    }

    private async Task SaveBookingInfo()
    {
        IsProcessing = true;
        HomeModel.EndDate = HomeModel.StartDate.AddDays(HomeModel.NoOfNights);
        await localStorage.SetItemAsync(SD.Local_InitialBooking, HomeModel);

        await LoadRooms();
        IsProcessing = false;
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IHotelRoomService hotelRoomService { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime jsRuntime { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private ILocalStorageService localStorage { get; set; }
    }
}
#pragma warning restore 1591
