#pragma checksum "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b4585ccdfefccfbb3e7f3ca3f59137ed3d629a15"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorWASM.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
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
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "nav");
            __builder.AddAttribute(1, "class", "navbar navbar-expand-sm navbar-dark bg-dark");
            __builder.AddAttribute(2, "b-69rflur3ak");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href=\"/SEP6_BlazorWASM\" b-69rflur3ak>MAYBE LOGO HERE</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(7, "b-69rflur3ak");
            __builder.AddMarkupContent(8, "<span class=\"navbar-toggler-icon\" b-69rflur3ak></span>");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n    ");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", (
#nullable restore
#line 8 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                 NavMenuCssClass

#line default
#line hidden
#nullable disable
            ) + " navbar-collapse");
            __builder.AddAttribute(12, "b-69rflur3ak");
            __builder.OpenElement(13, "a");
            __builder.AddAttribute(14, "style", "color:rebeccapurple");
            __builder.AddAttribute(15, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(16);
            __builder.AddAttribute(17, "class", "nav-link");
            __builder.AddAttribute(18, "href", "movieSearch");
            __builder.AddAttribute(19, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 10 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                                                                NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(20, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(21, "<span class=\"oi oi-monitor\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(22, "<span style=\"color:red\" b-69rflur3ak>Movies</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\r\n        ");
            __builder.OpenElement(24, "a");
            __builder.AddAttribute(25, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(26);
            __builder.AddAttribute(27, "class", "nav-link");
            __builder.AddAttribute(28, "href", "random");
            __builder.AddAttribute(29, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(30, "<span class=\"oi oi-star\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(31, "<span style=\"color:red\" b-69rflur3ak>Random</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(32, "\r\n        ");
            __builder.OpenElement(33, "a");
            __builder.AddAttribute(34, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(35);
            __builder.AddAttribute(36, "class", "nav-link");
            __builder.AddAttribute(37, "href", "myList");
            __builder.AddAttribute(38, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(39, "<span class=\"oi oi-list-rich\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(40, "<span style=\"color:red\" b-69rflur3ak>My list</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(41, "\r\n        ");
            __builder.OpenElement(42, "a");
            __builder.AddAttribute(43, "b-69rflur3ak");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(44);
            __builder.AddAttribute(45, "class", "nav-link");
            __builder.AddAttribute(46, "href", "actorSearch");
            __builder.AddAttribute(47, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(48, "<span class=\"oi oi-star\" style=\"color:red\" aria-hidden=\"true\" b-69rflur3ak></span> ");
                __builder2.AddMarkupContent(49, "<span style=\"color:red\" b-69rflur3ak>Actors</span>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n        ");
            __builder.AddMarkupContent(51, @"<div class=""dropdown show"" b-69rflur3ak><a class=""btn btn-secondary dropdown-toggle"" href=""#"" role=""button"" b-69rflur3ak>
                Genre
            </a>
            <div class=""dropdown-menu"" b-69rflur3ak><a class=""dropdown-item"" href=""#"" b-69rflur3ak>Action</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Drama</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Comedy</a>
                <a class=""dropdown-item"" href=""#"" b-69rflur3ak>Fuck</a></div></div>
        ");
            __builder.OpenElement(52, "div");
            __builder.AddAttribute(53, "b-69rflur3ak");
            __builder.OpenElement(54, "input");
            __builder.AddAttribute(55, "class", "form-control mr-sm-2");
            __builder.AddAttribute(56, "type", "search");
            __builder.AddAttribute(57, "placeholder", "Is this working?");
            __builder.AddAttribute(58, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 41 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                          InputValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(59, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => InputValue = __value, InputValue));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(60, "b-69rflur3ak");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n            ");
            __builder.OpenElement(62, "button");
            __builder.AddAttribute(63, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 43 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
                              SetValue

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(64, "class", "btn btn-outline-light my-2 my-sm-3");
            __builder.AddAttribute(65, "type", "submit");
            __builder.AddAttribute(66, "b-69rflur3ak");
            __builder.AddContent(67, "Find");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 47 "C:\Users\Borislav\Documents\Blazor\BlazorWASM\Shared\NavMenu.razor"
       
    public string InputValue { get; set; }
    private bool collapseNavMenu = true;
    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }
    private void SetValue(){
        searchInput.SetSearchInput(InputValue);
        Console.WriteLine("Value has been set to " + searchInput.GetSearchInput());
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager uriHelper { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private SingletonService searchInput { get; set; }
    }
}
#pragma warning restore 1591
