#pragma checksum "D:\Projects\C#\Bugger\BuggerUI\Features\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1da04d52e82017e44b67cac6405c84cae6aa08fc"
// <auto-generated/>
#pragma warning disable 1591
namespace BuggerUI.Features
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using System.Threading;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using BuggerUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using BuggerUI.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using BuggerUI.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using BuggerUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using DataAccessLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\Projects\C#\Bugger\BuggerUI\_Imports.razor"
using DataAccessLibrary.Models;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(0);
            __builder.AddAttribute(1, "href", "Data/DisplayBug");
            __builder.AddAttribute(2, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(3, "Bugs");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(5);
            __builder.AddAttribute(6, "href", "Workcation");
            __builder.AddAttribute(7, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(8, "Workcation");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(10);
            __builder.AddAttribute(11, "href", "/Data/DisplayBugByID");
            __builder.AddAttribute(12, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddContent(13, "Search");
            }
            ));
            __builder.CloseComponent();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
