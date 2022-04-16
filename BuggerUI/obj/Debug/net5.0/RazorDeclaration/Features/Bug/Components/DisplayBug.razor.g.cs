// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BuggerUI.Features.Bug.Components
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/Data/DisplayBug")]
    public partial class DisplayBug : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\C#\Bugger\BuggerUI\Features\Bug\Components\DisplayBug.razor"
       
    private List<BugModel> bugs;
    private DisplayBugModel newBug = new DisplayBugModel();

    protected override async Task OnInitializedAsync()
    {
        await GetBugs();
    }

    private async Task InsertBugData()
    {
        BugModel bug = new BugModel
        {
            BugTitle = newBug.BugTitle,
            BugDescription = newBug.BugDescription,
            BugCompleted = newBug.BugCompleted
        };

        await _bugData.InsertBug(bug);

        await GetBugs();

        newBug = new DisplayBugModel();
    }

    private async Task GetBugs()
    {
        IEnumerable<BugModel> bugsEnumerable = await _bugData.SelectAllBugs();
        bugs = bugsEnumerable.ToList();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IBugService _bugData { get; set; }
    }
}
#pragma warning restore 1591
