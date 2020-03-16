#pragma checksum "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2460b536727e72a551dcc225c54a38c82d596250"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ReservationDetails), @"mvc.1.0.view", @"/Views/Home/ReservationDetails.cshtml")]
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
#line 1 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\_ViewImports.cshtml"
using Flights_manager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\_ViewImports.cshtml"
using Flights_manager.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2460b536727e72a551dcc225c54a38c82d596250", @"/Views/Home/ReservationDetails.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43e5745ba7ebc7fbaec6b92a2279dc1353b23fc4", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ReservationDetails : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Flights_manager.Models.Reservation.ReservationDetailsViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
  
    ViewData["Title"] = "Reservation Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details for reservation with email: ");
#nullable restore
#line 6 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
                                   Write(Html.DisplayFor(m => Model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

<table class=""table"">
    <thead>
        <tr>
            <th>
                First name:
            </th>
            <th>
                Surname:
            </th>
            <th>
                Last name:
            </th>
            <th>
                USN:
            </th>
            <th>
                Phone number:
            </th>
            <th>
                Nationality:
            </th>
            <th>
                Ticket type:
            </th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 35 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
         foreach (var item in Model.Passengers)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 39 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 42 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Surname));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 45 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 48 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.USN));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 51 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 54 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 57 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
               Write(Html.DisplayFor(modelItem => item.TicketType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 60 "D:\GitHubCodes\Flights-manager\Flight-manager\Flights_manager\Views\Home\ReservationDetails.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Flights_manager.Models.Reservation.ReservationDetailsViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
