#pragma checksum "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d0b48e82a9473915f677b355d651a1c926d23e59"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservation_ReserveSucess), @"mvc.1.0.view", @"/Views/Reservation/ReserveSucess.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\_ViewImports.cshtml"
using WebApplication6.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d0b48e82a9473915f677b355d651a1c926d23e59", @"/Views/Reservation/ReserveSucess.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a098c058a45249d01a4d3ff09faab920e5a7f7f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservation_ReserveSucess : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplication6.Models.UserReserve>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("history.go(-1);"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n<div>\n    <h4>UserReserve</h4>\n    <hr />\n    <dl class=\"row\" style=\"color: white;\">\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 8 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.first_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 11 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.first_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 14 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.second_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 17 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.second_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 20 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 23 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.last_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 26 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.EGN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 29 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.EGN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 32 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 35 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 38 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 41 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 44 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 47 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 50 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.location_from));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 53 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.location_from));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 57 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.location_to));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 60 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.location_to));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n\t\t<dt class=\"col-sm-2\">\n\t\t\t");
#nullable restore
#line 63 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.date_and_time_taking_off));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 64 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
              
				int result = DateTime.Compare(Model.date_and_time_landing, Model.date_and_time_taking_off);
				if (result < 0)
				{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b48e82a9473915f677b355d651a1c926d23e5911570", async() => {
                WriteLiteral("Return to client detail");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n");
#nullable restore
#line 69 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"

					}
					else if (result == 0)
						Console.WriteLine("Pak ne");
					else if (result > 0)
						Console.WriteLine("Dobre");
				

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\t\t</dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 79 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.date_and_time_taking_off));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n          \n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 83 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.date_and_time_landing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 86 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.date_and_time_landing));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 89 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.type_of_plane));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 92 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.type_of_plane));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 95 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.unique));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 98 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.unique));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 101 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.pilot_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 104 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.pilot_name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 107 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.pass_cap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 110 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.pass_cap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n        <dt class = \"col-sm-2\">\n            ");
#nullable restore
#line 113 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayNameFor(model => model.buss_pass_cap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dt>\n        <dd class = \"col-sm-10\">\n            ");
#nullable restore
#line 116 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
       Write(Html.DisplayFor(model => model.buss_pass_cap));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </dd>\n    </dl>\n</div>\n<div>\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b48e82a9473915f677b355d651a1c926d23e5917835", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 121 "C:\Users\marti\OneDrive\Desktop\marti-branch\source\repos\WebApplication6\Views\Reservation\ReserveSucess.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d0b48e82a9473915f677b355d651a1c926d23e5920010", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n</div>\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplication6.Models.UserReserve> Html { get; private set; }
    }
}
#pragma warning restore 1591
