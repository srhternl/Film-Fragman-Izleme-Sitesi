#pragma checksum "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ceb0a92d71ea9ae70bc82710b2ae37c2a2dbc839"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminContactUs_Index), @"mvc.1.0.view", @"/Views/AdminContactUs/Index.cshtml")]
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
#line 1 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
using FilmPuanlamaSitesi.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ceb0a92d71ea9ae70bc82710b2ae37c2a2dbc839", @"/Views/AdminContactUs/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ae501c9594dd0807d3c8f531a8ee631f98fd85", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminContactUs_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div style=""margin-right:980px; margin-top:150px;"">

</div>

<table class=""table table-bordered"" style=""margin-right:100px; width:auto; height:auto; color:aqua;"">

    <tr>
        <th>TITLE</th>
        <th>E-MAIL</th>
        <th>PHONE NUMBER</th>
        <th>ADRESS</th>
        <th>UPDATE</th>
    </tr>
");
#nullable restore
#line 20 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
     foreach (var x in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 23 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
   Write(x.Baslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
   Write(x.Mail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
   Write(x.Telefon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 26 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
   Write(x.Adres);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 607, "\"", 642, 2);
            WriteAttributeValue("", 614, "/AdminContactUs/Update/", 614, 23, true);
#nullable restore
#line 27 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
WriteAttributeValue("", 637, x.ID, 637, 5, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">UPDATE</a></td>\r\n</tr>\r\n");
#nullable restore
#line 29 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminContactUs\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
