#pragma checksum "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "996711008b04b755221262a1a820810852ae7497"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Details), @"mvc.1.0.view", @"/Views/Product/Details.cshtml")]
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
#line 1 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\_ViewImports.cshtml"
using DatabaseImageProject;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"996711008b04b755221262a1a820810852ae7497", @"/Views/Product/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76d468f558edc62b73219397c6f67af53d4e80d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DatabaseImageProject.Models.Entities.Product>
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
#line 3 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>POP-UP Olarak yapmayı dene</h2>\r\n\r\n<div class=\"books-of-sujeesh\">\r\n    <h2 class=\"diplay-4\">");
#nullable restore
#line 10 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
                    Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" Details</h2>
    <div class=""container"">
        <section id=""sujeesh-books"" class=""row"">
            <div class=""col-xs-12 book-sec-head"">
            </div>
            <div class=""col-xs-12 col-sm-6 col-lg-4"">
                <div class=""book-card"">
                    <img");
            BeginWriteAttribute("src", " src=\"", 499, "\"", 524, 1);
#nullable restore
#line 17 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
WriteAttributeValue("", 505, Model.ProductImage, 505, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 525, "\"", 531, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <h3>");
#nullable restore
#line 18 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
                   Write(Model.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                    <p class=\"price\">");
#nullable restore
#line 19 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
                                Write(Model.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</p>\r\n                    <p>");
#nullable restore
#line 20 "C:\Users\Ahmet Ozturk\Desktop\Ahmet-OZTURK\DatabaseImageProject\DatabaseImageProject\Views\Product\Details.cshtml"
                  Write(Model.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n\r\n            </div>\r\n\r\n        </section>\r\n    </div>\r\n</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "996711008b04b755221262a1a820810852ae74976160", async() => {
                WriteLiteral("Back to Categories Page");
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
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DatabaseImageProject.Models.Entities.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
