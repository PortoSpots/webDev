using Microsoft.AspNetCore.Components;

namespace porto_spots.Pages
{
    public partial class SearchView
    {

        [Parameter] public string RawQuery { get; set; } = "";
    }
}
