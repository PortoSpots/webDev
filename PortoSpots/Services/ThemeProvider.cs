using MudBlazor;

namespace PortoSpots.Services
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
                AppbarBackground = "#ffffff"
            },

            LayoutProperties = new LayoutProperties()
            {
                DrawerWidthLeft = "260px",
                DrawerWidthRight = "300px"
            },
        };
    }
}

