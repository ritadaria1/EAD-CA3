// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace EADCA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "F:\EADCA3-master\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "F:\EADCA3-master\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "F:\EADCA3-master\_Imports.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "F:\EADCA3-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "F:\EADCA3-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "F:\EADCA3-master\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "F:\EADCA3-master\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "F:\EADCA3-master\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "F:\EADCA3-master\_Imports.razor"
using EADCA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "F:\EADCA3-master\_Imports.razor"
using EADCA3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "F:\EADCA3-master\Pages\Counter.razor"
        private Root main;
    private Boolean found;
    private int count = 0;
    private string errormessage;

    private async Task GetDataAsync()
    {
        try
        {
            string uri = "https://ws.audioscrobbler.com/2.0/?method=artist.gettoptracks&artist=cher&api_key=6fb86347aefc0240d93a8d2a9e08f9d8&format=json";
            main = await Http.GetJsonAsync<Root>(uri);
            found = true;
            errormessage = String.Empty;
        }
        catch (Exception e)
        {

            found = false;
            errormessage = e.Message;


        }
    }





    protected override async Task OnInitializedAsync()
    {
        await GetDataAsync();
    }



    public class Artist
    {
        public string name { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
    }

    public class Image
    {
       
        public string Text { get; set; }
        public string size { get; set; }
    }

    public class Attr
    {
        public string rank { get; set; }
    }

    public class Track
    {
        public string name { get; set; }
        public string playcount { get; set; }
        public string listeners { get; set; }
        public string mbid { get; set; }
        public string url { get; set; }
        public string streamable { get; set; }
        public Artist artist { get; set; }
        public List<Image> image { get; set; }
        
        public Attr Attr { get; set; }
    }

    public class Attr2
    {
        public string artist { get; set; }
        public string page { get; set; }
        public string perPage { get; set; }
        public string totalPages { get; set; }
        public string total { get; set; }
    }

    public class Toptracks
    {
        public List<Track> track { get; set; }
        
        public Attr2 Attr { get; set; }
    }

    public class Root
    {
        public Toptracks toptracks { get; set; }
    }




#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
