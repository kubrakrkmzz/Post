#pragma checksum "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8a1749124e4adbab329c243ad590ec498f4415dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Depart_Index), @"mvc.1.0.view", @"/Views/Depart/Index.cshtml")]
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
#line 2 "C:\Users\Berkan\source\repos\Post\Post\Views\_ViewImports.cshtml"
using Post.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a1749124e4adbab329c243ad590ec498f4415dd", @"/Views/Depart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8630fd8ec070a9f60b356b687361a94e66c957a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Depart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Post.Models.Department>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_SideLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n<table class=\"table table-bordered\">\r\n\r\n    <tr>\r\n        <!--Tablo satırı tutar-->\r\n\r\n        <th>ID</th>\r\n        <th>Department</th>\r\n        <th>Delete</th>\r\n        <th>Update</th>\r\n        <th>Details</th>\r\n    </tr>\r\n\r\n");
#nullable restore
#line 20 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
     foreach (Post.Models.Department x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
           Write(x.DepartId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
           Write(x.DepartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 531, "\"", 562, 2);
            WriteAttributeValue("", 538, "DeleteDepart/", 538, 13, true);
#nullable restore
#line 25 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
WriteAttributeValue("", 551, x.DepartId, 551, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 621, "\"", 650, 2);
            WriteAttributeValue("", 628, "ViewDepart/", 628, 11, true);
#nullable restore
#line 26 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
WriteAttributeValue("", 639, x.DepartId, 639, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"btn btn-success\">Update</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 710, "\"", 742, 2);
            WriteAttributeValue("", 717, "DetailsDepart/", 717, 14, true);
#nullable restore
#line 27 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"
WriteAttributeValue("", 731, x.DepartId, 731, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("class=\"btn btn-outline-dark\" style=\"background-color:#f3dd61 \">Details</a></td>\r\n           \r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\Berkan\source\repos\Post\Post\Views\Depart\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <!-- alternatifleri foreach(var x in Model)
            {
        <tr>
            <td>x.DepartId</td> başlarında et işareti olucak tabi
            <td>x.DepartName</td>

        </tr>
    }-->

</table>
<a href =""/Depart/NewDepart/"" class=""btn btn-primary"">New Department</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Post.Models.Department>> Html { get; private set; }
    }
}
#pragma warning restore 1591
