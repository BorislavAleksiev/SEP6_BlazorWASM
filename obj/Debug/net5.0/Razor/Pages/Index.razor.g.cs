#pragma checksum "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b076a0dc905cb9ddb54abdcdbfad92c19e6a496d"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 2 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using BlazorWASM;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using BlazorWASM.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
using System.Net.Http.Headers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Log in</h1>\r\n");
            __builder.OpenElement(1, "ul");
            __builder.OpenElement(2, "li");
            __builder.OpenElement(3, "input");
            __builder.AddAttribute(4, "class", "form-control mr-sm-2");
            __builder.AddAttribute(5, "type", "search");
            __builder.AddAttribute(6, "placeholder", "Username");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 11 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
                      username

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => username = __value, username));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "li");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "class", "form-control mr-sm-2");
            __builder.AddAttribute(13, "type", "search");
            __builder.AddAttribute(14, "placeholder", "Password");
            __builder.AddAttribute(15, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 14 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
                      password

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(16, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => password = __value, password));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n    ");
            __builder.OpenElement(18, "li");
            __builder.OpenElement(19, "button");
            __builder.AddAttribute(20, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 17 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
                          Post

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(21, "Login");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Pages\Index.razor"
      
    public string username {get; set;}
    public string password {get; set;}

    string stringPayload;
    HttpContent content;
    async Task Post()
    {
    IEnumerable<KeyValuePair<string, string>> pairs = new List<KeyValuePair<string,string>>(){
            new KeyValuePair<string, string>("username",username),
            new KeyValuePair<string, string>("password",password),
    };
    content = new FormUrlEncodedContent(pairs);
    HttpResponseMessage response = await client.PostAsJsonAsync("https://us-central1-userservice-314812.cloudfunctions.net/createUser/post", content);
    Console.WriteLine(content.ToString());
    string myResponse = await response.Content.ReadAsStringAsync();
        //if(myResponse == "Thank you for this dump. I hope you have a lovely day!"){
        //    searchInput.displayName = "NO SUCH ACCOUNT";
        //} else{
            searchInput.displayName = myResponse;
        //}
    Console.WriteLine(myResponse);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService searchInput { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
    }
}
#pragma warning restore 1591
