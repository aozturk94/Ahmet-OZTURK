#pragma checksum "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57596ff6d2f2963f266f7b3d80462ed81b544fb1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Ticket_TicketDetails), @"mvc.1.0.view", @"/Views/Ticket/TicketDetails.cshtml")]
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
#nullable restore
#line 5 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57596ff6d2f2963f266f7b3d80462ed81b544fb1", @"/Views/Ticket/TicketDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cfccfdd104006d7b9fc572a0cdbe224c801461e", @"/Views/_ViewImports.cshtml")]
    public class Views_Ticket_TicketDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RouteTicket>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n    <div class=\"text-center\">\r\n        <br />\r\n        <br />\r\n        <br /><p> Mr./Mrs. ");
#nullable restore
#line 7 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                      Write(Model.Ticket.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 7 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                                 Write(Model.Ticket.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral(", your ticket request from ");
#nullable restore
#line 7 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                                                                                          Write(Model.Ticket.TravelFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 7 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                                                                                                                      Write(Model.Ticket.TravelTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" has been successfully defined.</p>        
        <h3>Your Ticket</h3>
        <br />
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-6 p-0"">
                    <div class=""card border-info pt-2"" style=""border-right: 2px dotted black !important"">
                        <div class=""d-flex justify-content-center align-items-center"" style=""border-radius:203px; height:203px; width:203px; background: #F8FAF5; margin:0 auto;"">
                            <i class=""fas fa-check-circle"" style=""font-size:156px; color:green;""></i>
                        </div>
                        <h2>Succeed</h2>
                        <h2> PRN Number: ");
#nullable restore
#line 18 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                    Write(Model.Ticket.PeronNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h2>
                    </div>
                </div>
                <div class=""col-md-6 p-0"">
                    <div class=""card border-info pt-2 container-fluid"" style=""border-left: 2px dotted black !important"">
                        <hr />
                        <div class=""d-flex justify-content-around"">
                        <p>DATE</p><p>");
#nullable restore
#line 25 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                 Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p><p>Time</p><p>");
#nullable restore
#line 25 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                                              Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>\r\n                        <hr />\r\n                        <h3>Passenger:</h3>\r\n                        <h2>");
#nullable restore
#line 29 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                       Write(Model.Ticket.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                                  Write(Model.Ticket.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n                        <h4>Price:<small>");
#nullable restore
#line 30 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                    Write(Model.Ticket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</small></h4>\r\n                        <hr />\r\n                        <h5>\r\n                            ");
#nullable restore
#line 33 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                       Write(Model.Ticket.TravelFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral(" <i class=\"fa-solid fa-arrow-right\"></i>\r\n                            ");
#nullable restore
#line 34 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                       Write(Model.Ticket.TravelTo);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                        </h5>
                    </div>
                </div>
            </div>

        </div>


        <table class=""table table table-bordered shadow-sm d-none"">
            <thead>
                <tr>
                    <th style=""width:40px;"">Ticket No</th>
                    <th style=""width:200px;"">Name</th>
                    <th");
            BeginWriteAttribute("style", " style=\"", 2249, "\"", 2257, 0);
            EndWriteAttribute();
            WriteLiteral(@">Phone Number</th>
                    <th style=""width:105px;"">Travel From</th>
                    <th style=""width:105px;"">Travel To</th>
                    <th style=""width:60px;"">Seat Number</th>
                    <th style=""width:80px;"">Price</th>
                    <th style=""width:200px;"">Date - Time</th>

                    <th style=""width:75px;"">Sefer No</th>

                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>");
#nullable restore
#line 61 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.TicketId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 62 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.CostumerName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 62 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                              Write(Model.Ticket.CosturmerSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 64 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 65 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.TravelFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 66 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.TravelTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 67 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.SeatNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 68 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₺</td>\r\n                    <td>");
#nullable restore
#line 69 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 69 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                                 Write(Model.Time);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                    <td>");
#nullable restore
#line 71 "C:\Users\Wissen\Desktop\Ahmet-OZTURK\TravelAgencyBookingApp\Bus-Ticket-Booking\Bus-Ticket-Booking.WebUI\Views\Ticket\TicketDetails.cshtml"
                   Write(Model.Ticket.RouteId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                </tr>\r\n            </tbody>\r\n        </table>\r\n        <br />\r\n    </div>");
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
