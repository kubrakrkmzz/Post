#pragma checksum "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7f48a08d454dafe39bc01af51957a6411dc2a3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Person_Index), @"mvc.1.0.view", @"/Views/Person/Index.cshtml")]
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
#line 1 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
using Post.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7f48a08d454dafe39bc01af51957a6411dc2a3", @"/Views/Person/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8630fd8ec070a9f60b356b687361a94e66c957a9", @"/Views/_ViewImports.cshtml")]
    public class Views_Person_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Personal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_SideLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<br />

<table class=""table table-bordered"">
    <tr>
        
        <th>UserName</th>
        <th>Name</th>
        <th>Surname</th>
        <th>IdentificationNumber</th>
        <th>E-mail</th>
        <th>Department</th>
        <th>Delete</th>
        <th>Update</th>
    </tr>

");
#nullable restore
#line 23 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
     foreach(var x in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    \r\n    <td>");
#nullable restore
#line 27 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.UserName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 28 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 29 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.SurName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 30 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.IdentificationNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 31 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 32 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
   Write(x.depart.DepartName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 673, "\"", 706, 2);
            WriteAttributeValue("", 680, "/Depart/DeleteDepart/", 680, 21, true);
#nullable restore
#line 33 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
WriteAttributeValue("", 701, x.Id, 701, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 758, "\"", 789, 2);
            WriteAttributeValue("", 765, "/Depart/ViewDepart/", 765, 19, true);
#nullable restore
#line 34 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
WriteAttributeValue("", 784, x.Id, 784, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Update</a></td>\r\n\r\n\r\n</tr>\r\n");
#nullable restore
#line 38 "C:\Users\Berkan\source\repos\Post\Post\Views\Person\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Person/NewPerson/\" class=\"btn btn-primary\">New Person</a>\r\n\r\n");
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
