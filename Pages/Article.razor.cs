﻿using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using MudBlazor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace porto_spots.Pages
{
    public partial class Article
    {
        private string time="";

        [Inject] IJSRuntime JSRuntime{ get; set; }
        [Inject] NavigationManager NavigationManager{ get; set; }

        //UI Aux Parameters
        private bool isFullCarouselOpen = false;
        private int fullScreenTabIndex=-1, screenTabIndex=-1;

        //Page Data Parameters
        [Parameter] public string ArticleName { get; set; } = "";
        private IList<string> articlePicUrls= new List<string>();

        protected override async Task OnInitializedAsync()
        {
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632813101586-c6243f84a800?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632814501477-7f3a88232a17?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1172&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632767576183-8a22609cc9e5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1586227740560-8cf2732c1531?ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1261&q=80");
            time=DateTime.Now.ToLongTimeString();
            await InvokeAsync(StateHasChanged);
            await base.OnInitializedAsync();
        }


        private async void OpenOverlay()
        {
            isFullCarouselOpen = true;
            Console.WriteLine("Open overlay");
            fullScreenTabIndex = screenTabIndex;
            await InvokeAsync(StateHasChanged);
                 
        }

        private async void CloseOverlay()
        {
            isFullCarouselOpen = false;
            await InvokeAsync(StateHasChanged);
        }


        private async void ShareFacebook()
		{
            var url = $"http://www.facebook.com/sharer.php?u={NavigationManager.Uri}";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }

        private async void ShareWhatsApp()
        {
            var url = $"https://wa.me/?text=PortoSpots {NavigationManager.Uri}";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }

        private async void ShareTwitter()
        {
            var url = $"https://twitter.com/share?url={NavigationManager.Uri}&text=PortoSpots";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }

        private async void ShareLinkedIn()
        {
            var url = $"https://www.linkedin.com/shareArticle?url={NavigationManager.Uri}&title=PortoSpots";
            await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        }

        //private async void SharePinterest()
        //{
        //    var url = $"https://pinterest.com/pin/create/bookmarklet/?media=[post-img]&url={NavigationManager.Uri}&is_video=[is_video]&description=[post-title] ";
        //    await JSRuntime.InvokeAsync<object>("open", url, "_blank");
        //}

        private async void CopyLink()
		{
            await JSRuntime.InvokeVoidAsync("clipboardCopy.copyText", NavigationManager.Uri);
        }

    }
}
