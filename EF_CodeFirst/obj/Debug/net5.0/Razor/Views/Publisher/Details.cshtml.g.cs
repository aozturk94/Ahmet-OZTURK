#pragma checksum "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6e95bf2271a718daae9c058c7feb9465ad1022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Publisher_Details), @"mvc.1.0.view", @"/Views/Publisher/Details.cshtml")]
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
#line 1 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_Codefirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_Codefirst.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst.Models.Context;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\_ViewImports.cshtml"
using EF_CodeFirst.Models.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6e95bf2271a718daae9c058c7feb9465ad1022", @"/Views/Publisher/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92d1a62ed322572dc8808c6cb7a0b06510b4d167", @"/Views/_ViewImports.cshtml")]
    public class Views_Publisher_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Publisher>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 class=\"diplay-4\">");
#nullable restore
#line 7 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
                Write(Model.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Details</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        #\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 13 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
   Write(Model.PublisherId);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        Name:\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 21 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
   Write(Model.PublisherName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        City:\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 29 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
   Write(Model.PublisherCity);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-3\">\r\n        Mail:\r\n    </div>\r\n    <div class=\"col-sm-5\">\r\n        ");
#nullable restore
#line 37 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\EF_CodeFirst\Views\Publisher\Details.cshtml"
   Write(Model.PublisherMail);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ac6e95bf2271a718daae9c058c7feb9465ad10226219", async() => {
                WriteLiteral("Back to Authors Page");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Publisher> Html { get; private set; }
    }
}
#pragma warning restore 1591
