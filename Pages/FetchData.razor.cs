using porto_spots.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace porto_spots.Pages
{
    public partial class FetchData
{
        private string contentString="Loading";
    //private ItemTest[] items;

    protected override async Task OnInitializedAsync()
    {
            //items = await Http.GetFromJsonAsync<ItemTest[]>("sample-data/records.json");
            contentString = await GitFetcher.FetchStringAsync(new GitLink().Append_EndUrl("README.md"));

    }
    //public record ItemTest
    //{
    //    public string Thumbnail { get; set; }
    //    public string Title { get; set; }
    //    public string Description { get; set; }

    //}
}
}
