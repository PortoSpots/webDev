using MudBlazor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace porto_spots.Services
{
    public static class ThemeProvider
    {
        public static MudTheme DefaultTheme = new MudTheme()
        {
            Palette = new Palette()
            {
                Primary = "#1F8BE9",
                Secondary = "#FFA62B",
                Tertiary = "#EDE7E3",
                Dark = "#3E1929",
                Surface = "#ffffff",
                AppbarBackground = "#ffffff",
                OverlayDark= "#212121e6"
            },

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"
            },
        };
    }
}