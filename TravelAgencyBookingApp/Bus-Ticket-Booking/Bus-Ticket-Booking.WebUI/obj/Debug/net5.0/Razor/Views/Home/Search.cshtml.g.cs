#pragma checksum "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b29042f1a66548d2cec7ce3615ef309280dc7524"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Search), @"mvc.1.0.view", @"/Views/Home/Search.cshtml")]
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
#line 1 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Bus_Ticket_Booking.WebUI.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b29042f1a66548d2cec7ce3615ef309280dc7524", @"/Views/Home/Search.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"24bc4c41f081dad977726564d7837b3fb8df39dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Search : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"text-center mt-4\">Your Ticket</h3>\r\n    <br />\r\n");
            WriteLiteral(@"                    <div class=""ticket container"">
                        <div class=""left my-3 mx-1"">
                            <div class=""image"">
                            </div>
                            <div class=""ticket-info"">
                                <p class=""date"">
                                    <span>DATE</span>
                                    <span class=""june-29"">");
#nullable restore
#line 15 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                                     Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                    <span><small class=\"text-muted\">Time: ");
#nullable restore
#line 16 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                                                     Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></span>\r\n                                </p>\r\n                                <div class=\"show-name\">\r\n                                    <h1>Costumer: </h1>\r\n                                    <h2>");
#nullable restore
#line 20 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                   Write(Model.Ticket.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 20 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                                              Write(Model.Ticket.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                                </div>\r\n                                <div class=\"time\">\r\n                                    <p>Price:<span> ₺");
#nullable restore
#line 23 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                                Write(Model.Ticket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></p>
                                    <p>DOORS <span>*</span> 7:00 PM</p>
                                </div>
                                <p class=""location"">
                                    <span>East High School</span>
                                    <span class=""separator""><i class=""far fa-smile""></i></span><span>Salt Lake City, Utah</span>
                                </p>
                            </div>
                        </div>
                        <div class=""right"">
                            <div class=""right-info-container"">
                                <div class=""time"">
                                    <p>8:00 PM <span>TO</span> 11:00 PM</p>
                                    <p>DOORS <span>*</span> 7:00 PM</p>
                                </div>
                                <div class=""barcode"">
                                    <img src=""https://external-preview.redd.it/cg8k976AV52mDvDb5jDVJABPrSZ3tpi1aXhPjgcDTbw.png?auto=web");
            WriteLiteral("p&s=1c205ba303c1fa0370b813ea83b9e1bddb7215eb\" alt=\"QR code\">\r\n                                </div>\r\n                                <p class=\"ticket-number\">\r\n                                    #");
#nullable restore
#line 42 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                Write(Model.Ticket.PeronNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </p>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n");
#nullable restore
#line 47 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <h2>Hopp</h2>\r\n");
#nullable restore
#line 51 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Home\Search.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RouteTicket> Html { get; private set; }
    }
}
#pragma warning restore 1591
