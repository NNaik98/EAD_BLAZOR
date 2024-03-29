// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace CA3_BlazorApp.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using CA3_BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "N:\College\EAD\EAD_BLAZOR\_Imports.razor"
using CA3_BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
using System.Runtime.Serialization;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/newsfetch")]
    public partial class NewsFetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 84 "N:\College\EAD\EAD_BLAZOR\Pages\NewsFetchData.razor"
       

    private string errormessage;
    private bool found;

    NewsQueryData query = new NewsQueryData();

    public string name { get; set; } = "sports";

    public async Task GetNewsAsync()
    {
        found = false;
        try
        {
            string uri = "https://newsapi.org/v2/everything?q=" + name + "&apiKey=f74374b084a74f87a9c6270128e9962e";

            query.newsData = await Http.GetFromJsonAsync<Root>(uri);
            found = true;
            errormessage = String.Empty;
        }
        catch (Exception e)
        {
            errormessage = e.Message;
        }
    }

    protected override async Task OnInitializedAsync()
    {
        await GetNewsAsync();
    }


    public async Task PressEnter(KeyboardEventArgs e)
    {
        if (e.Key == "Enter")
        {
            await GetNewsAsync();
        }
    }



#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
