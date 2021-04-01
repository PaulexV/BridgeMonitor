#pragma checksum "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1a5b906e30790d762462f6b418eafb2be959d582"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/home/paulex/Ynov/dotNET/PontChaban/Views/_ViewImports.cshtml"
using PontChaban;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/paulex/Ynov/dotNET/PontChaban/Views/_ViewImports.cshtml"
using PontChaban.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1a5b906e30790d762462f6b418eafb2be959d582", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa377157aa6c922b6e93fde37e0cb9590669c0cd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<BridgeInfos>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Prochaine Fermeture</h1>\r\n\r\n");
#nullable restore
#line 6 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
  
    var SortedListOfClosing = Model.OrderBy(closing =>
            Convert.ToDateTime(closing.ClosingDate)).ToList();


#line default
#line hidden
#nullable disable
            WriteLiteral(@"<table class=""table"">
    <thead>
        <tr>
            <th>Cause / Bateau</th>
            <th>Date de la fermeture</th>
            <th>Heure de réouverture</th>
            <th>Durée de la prochaine fermeture</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 21 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
         foreach (var boat in SortedListOfClosing)
        {
            var duree = boat.ReopeningDate - boat.ClosingDate;
            if (DateTime.Now < boat.ClosingDate)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>");
#nullable restore
#line 27 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                   Write(boat.BoatName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 27 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                                    Write(boat.ClosingType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 28 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                   Write(boat.ClosingDate.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 29 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                   Write(boat.ReopeningDate.ToString("F", CultureInfo.CreateSpecificCulture("fr-FR")));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                   Write(duree);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 32 "/home/paulex/Ynov/dotNET/PontChaban/Views/Home/Index.cshtml"
                break;
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<BridgeInfos>> Html { get; private set; }
    }
}
#pragma warning restore 1591
