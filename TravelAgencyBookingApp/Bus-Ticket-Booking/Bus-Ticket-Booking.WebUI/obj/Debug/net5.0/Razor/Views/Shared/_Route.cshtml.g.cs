#pragma checksum "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "287307b55c111ebaa3e0b1b974e6c69e9a52fe4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Route), @"mvc.1.0.view", @"/Views/Shared/_Route.cshtml")]
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
#line 1 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"287307b55c111ebaa3e0b1b974e6c69e9a52fe4a", @"/Views/Shared/_Route.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1038a677048de4b662e92c161530d9cc92484651", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Route : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Route>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-title"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Yolculuk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; font-size:24px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Ticket", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-sm"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n<div class=\"card mb-4 mt-3 shadow\">\n\n    <div class=\"card-body\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287307b55c111ebaa3e0b1b974e6c69e9a52fe4a5637", async() => {
#nullable restore
#line 6 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                                                                                    Write(Model.StartLocation);

#line default
#line hidden
#nullable disable
                WriteLiteral(" <i class=\"fas fa-long-arrow-alt-right\"></i> ");
#nullable restore
#line 6 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                                                                                                                                                     Write(Model.EndLocation);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 6 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                               WriteLiteral(Model.RouteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n        <p class=\"card-text\"><b style=\"font-size:19px;\">Güzergah:</b>  ");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                  Write(Model.StartLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                         Write(Model.FirstStation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                                               Write(Model.SecondStation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                                                                      Write(Model.ThirdStation);

#line default
#line hidden
#nullable disable
            WriteLiteral(" > ");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                                                                                                                            Write(Model.EndLocation);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><br />\n\n        <p style=\" font-size:24px; text-align:center;\">\n            <b>");
#nullable restore
#line 10 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
          Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </b>\n            - ");
#nullable restore
#line 11 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
         Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n        </p>\n\n\n    </div>\n    <div class=\"card-footer text-center\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "287307b55c111ebaa3e0b1b974e6c69e9a52fe4a12015", async() => {
                WriteLiteral("İncele");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 17 "C:\Users\Ahmet Ozturk\source\repos\aozturk94\WEB7_Project\Entity Framework\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Shared\_Route.cshtml"
                                                          WriteLiteral(Model.RouteId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n</div>   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Route> Html { get; private set; }
    }
}
#pragma warning restore 1591
