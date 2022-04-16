#pragma checksum "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "43db6c8b6b96aaa1394b3322ad74241baaa98079"
// <auto-generated/>
#pragma warning disable 1591
namespace BuggerUI.Pages
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
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "bg-gray-100 grid");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "max-w-6xl px-8 py-12 w-full mx-auto");
            __builder.AddMarkupContent(4, "<h1 class=\"text-indigo-500 text-3xl text-center p-8\">Bugs</h1>\r\n        ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "flex flex-row justify-center items-center gap-4");
            __builder.AddMarkupContent(7, "<h4 class=\"text-gray-900 text-xl text-center \">Insert New Bug</h4>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(8);
            __builder.AddAttribute(9, "Model", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 10 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                              newBug

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(10, "OnValidSubmit", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<Microsoft.AspNetCore.Components.Forms.EditContext>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Forms.EditContext>(this, 
#nullable restore
#line 10 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                      InsertBugData

#line default
#line hidden
#nullable disable
            )));
            __builder.AddAttribute(11, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.DataAnnotationsValidator>(12);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(13, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.ValidationSummary>(14);
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(15, "\r\n\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(16);
                __builder2.AddAttribute(17, "id", "bugTitle");
                __builder2.AddAttribute(18, "class", "border-2");
                __builder2.AddAttribute(19, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 14 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                      newBug.BugTitle

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(20, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBug.BugTitle = __value, newBug.BugTitle))));
                __builder2.AddAttribute(21, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBug.BugTitle));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(22, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(23);
                __builder2.AddAttribute(24, "id", "bugDescription");
                __builder2.AddAttribute(25, "class", "border-2");
                __builder2.AddAttribute(26, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 15 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                            newBug.BugDescription

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(27, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBug.BugDescription = __value, newBug.BugDescription))));
                __builder2.AddAttribute(28, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => newBug.BugDescription));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(29, "\r\n                ");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputCheckbox>(30);
                __builder2.AddAttribute(31, "id", "bugIsComplete");
                __builder2.AddAttribute(32, "Value", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 16 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                               newBug.BugCompleted

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(33, "ValueChanged", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.Boolean>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.Boolean>(this, global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => newBug.BugCompleted = __value, newBug.BugCompleted))));
                __builder2.AddAttribute(34, "ValueExpression", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.Boolean>>>(() => newBug.BugCompleted));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(35, "\r\n\r\n                ");
                __builder2.AddMarkupContent(36, "<button type=\"submit\" class=\"rounded-md shadow-md px-2 py-2 bg-indigo-500 text-white uppercase text-base font-bold\">Submit</button>");
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
#nullable restore
#line 22 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
         if (bugs is null)
        {

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(37, "<p>Loading...</p>");
#nullable restore
#line 25 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
        }
        else
        {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(38, "div");
            __builder.AddAttribute(39, "class", "py-6");
            __builder.AddMarkupContent(40, "<h4 class=\"text-gray-900 text-2xl py-6\">Current Bugs</h4>\r\n                ");
            __builder.OpenElement(41, "div");
            __builder.AddAttribute(42, "class", "grid gap-6");
#nullable restore
#line 31 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                     foreach (var item in bugs)
                    {

#line default
#line hidden
#nullable disable
            __builder.OpenComponent<BuggerUI.Components.BugCard>(43);
            __builder.AddAttribute(44, "BugID", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Int32>(
#nullable restore
#line 33 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                         item.BugID

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(45, "BugTitle", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 34 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                            item.BugTitle

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "BugCompleted", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Boolean>(
#nullable restore
#line 35 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                item.BugCompleted

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(47, "BugDescription", global::Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 36 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                                                  item.BugDescription

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseComponent();
#nullable restore
#line 37 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
                    }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 40 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 44 "D:\Projects\C#\Bugger\BuggerUI\Pages\DisplayBug.razor"
       
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
