#pragma checksum "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f15b87ee643266abe2a07b5e37496e861234212"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_AdminGenre_Update), @"mvc.1.0.view", @"/Views/AdminGenre/Update.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f15b87ee643266abe2a07b5e37496e861234212", @"/Views/AdminGenre/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ae501c9594dd0807d3c8f531a8ee631f98fd85", @"/Views/_ViewImports.cshtml")]
    public class Views_AdminGenre_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmPuanlamaSitesi.Models.Siniflar.Genre>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-right:750px; margin-top:100px;\">\r\n    <br />\r\n");
#nullable restore
#line 9 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
     using (Html.BeginForm("UpdateGenre", "AdminGenre", FormMethod.Post))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 13 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 15 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 17 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 19 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.FilmLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 21 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.FilmLink));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 23 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.Kategori));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 25 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Kategori));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 27 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.Sure));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 29 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Sure));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 31 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.LabelFor(x => x.FilmResim));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 33 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
   Write(Html.TextBoxFor(x => x.FilmResim));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <div style=\"margin-top:10px;\">\r\n            <button class=\"btn btn-primary\">UPDATE</button>\r\n        </div>\r\n");
#nullable restore
#line 38 "C:\Users\Home\Desktop\git\Web-Programlama\FilmPuanlamaSitesi\FilmPuanlamaSitesi\Views\AdminGenre\Update.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmPuanlamaSitesi.Models.Siniflar.Genre> Html { get; private set; }
    }
}
#pragma warning restore 1591
