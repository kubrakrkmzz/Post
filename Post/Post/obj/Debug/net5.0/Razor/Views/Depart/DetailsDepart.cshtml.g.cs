#pragma checksum "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "11828e9eb50df6b687ad379b36fdffa187196ea9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_DetailsDepart), @"mvc.1.0.view", @"/Views/Depart/DetailsDepart.cshtml")]
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
#line 1 "C:\Users\Berkan\source\repos\Post\Post\Views\_ViewImports.cshtml"
using Post;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
using Post.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"11828e9eb50df6b687ad379b36fdffa187196ea9", @"/Views/Depart/DetailsDepart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8630fd8ec070a9f60b356b687361a94e66c957a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_DetailsDepart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
  
    ViewData["Title"] = "DetailsDepart";
    Layout = "~/Views/Shared/_SideLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n\r\n<h2 style=\"color:forestgreen\">");
#nullable restore
#line 10 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
                         Write(ViewBag.dptname);

#line default
#line hidden
#nullable disable
            WriteLiteral(" Department</h2>\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n\r\n        <th>UserName</th>\r\n        <th>Name</th>\r\n        <th>Surname</th>\r\n        <th>IdentificationNumber</th>\r\n\r\n    </tr>\r\n\r\n");
#nullable restore
#line 23 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n\r\n            <td>");
#nullable restore
#line 27 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
           Write(x.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 28 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
           Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
           Write(x.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
           Write(x.IdentificationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 34 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\DetailsDepart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Personal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
