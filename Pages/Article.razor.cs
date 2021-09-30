using Microsoft.AspNetCore.Components;
using MudBlazor;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace porto_spots.Pages
{
    public partial class Article
    {

        // UI Bindings
        private MudCarousel<string> fullCarousel;

        //UI Aux Parameters
        private bool isFullCarouselOpen = false;
        private int fullScreenTabIndex = 0;

        //Page Data Parameters
        [Parameter] public string ArticleName { get; set; } = "";
        private IList<string> articlePicUrls= new List<string>();

        protected override async Task OnInitializedAsync()
        {
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632813101586-c6243f84a800?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632814501477-7f3a88232a17?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1172&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1632767576183-8a22609cc9e5?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1170&q=80");
            articlePicUrls.Add($"https://images.unsplash.com/photo-1586227740560-8cf2732c1531?ixid=MnwxMjA3fDF8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=1261&q=80");
            await InvokeAsync(StateHasChanged);
            await base.OnInitializedAsync();
        }


        public async void OpenOverlay()
        {
            isFullCarouselOpen = true;
            Console.WriteLine("Open overlay");
            await InvokeAsync(StateHasChanged);
        }

        public async void CloseOverlay()
        {
            isFullCarouselOpen = false;
            await InvokeAsync(StateHasChanged);
        }

    }
}
