#pragma checksum "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "80d981a8c378a4e4bae02c9aa99f561d5c65226f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
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
#line 1 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\_ViewImports.cshtml"
using Rent_it;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\_ViewImports.cshtml"
using Rent_it.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"80d981a8c378a4e4bae02c9aa99f561d5c65226f", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f0332ceccccc8006a9290345a53a12764787ba9", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Rent_it.Models.Customer>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
  
    ViewBag.Title = Model.Name;
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 8 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n<ul>\r\n    <li>Membership Type: ");
#nullable restore
#line 10 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
                    Write(Model.MembershipType.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 11 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
     if (Model.Birthdate.HasValue)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li>Birthdate: ");
#nullable restore
#line 13 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
                  Write(Model.Birthdate.Value.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 14 "C:\Users\Ramy\Desktop\Microsoft-visual-studio-projects\Rent-it\Rent-it\Views\Customers\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Rent_it.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591
