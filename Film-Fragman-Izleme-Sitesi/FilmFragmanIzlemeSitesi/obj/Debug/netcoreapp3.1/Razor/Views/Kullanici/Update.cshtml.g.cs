#pragma checksum "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c34edcdf74abf775ddb38dc5a0984998848a23bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kullanici_Update), @"mvc.1.0.view", @"/Views/Kullanici/Update.cshtml")]
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
#line 1 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\_ViewImports.cshtml"
using FilmPuanlamaSitesi.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c34edcdf74abf775ddb38dc5a0984998848a23bd", @"/Views/Kullanici/Update.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"05ae501c9594dd0807d3c8f531a8ee631f98fd85", @"/Views/_ViewImports.cshtml")]
    public class Views_Kullanici_Update : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FilmPuanlamaSitesi.Models.Siniflar.Kullanici>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
  
    ViewData["Title"] = "Update";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div style=\"margin-right:750px; margin-top:100px; color:aqua;\">\r\n    <br />\r\n");
#nullable restore
#line 9 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
     using (Html.BeginForm("UpdateUser", "Kullanici", FormMethod.Post))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <label>ID</label>\r\n        <br />\r\n");
#nullable restore
#line 13 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.TextBoxFor(x => x.ID, new { @class = "form-control", @readonly = "readonly" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Kullanıcı Adı</label>\r\n        <br />\r\n");
#nullable restore
#line 17 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.TextBoxFor(x => x.KullaniciAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.KullaniciAd, "", new { @style = "color:blue" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Email</label>\r\n        <br />\r\n");
#nullable restore
#line 22 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Email, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.Email, "", new { @style = "color:blue" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n        <label>Şifre</label>\r\n        <br />\r\n");
#nullable restore
#line 27 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.TextBoxFor(x => x.Sifre, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
   Write(Html.ValidationMessageFor(x => x.Sifre, "", new { @style = "color:blue" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"margin-top:10px;\">\r\n            <button class=\"btn btn-primary\">Update User</button>\r\n        </div>\r\n");
#nullable restore
#line 32 "C:\Users\Home\Desktop\YAZILIM PROJELER\Web-Programlama\Film-Fragman-Izleme-Sitesi\FilmFragmanIzlemeSitesi\Views\Kullanici\Update.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FilmPuanlamaSitesi.Models.Siniflar.Kullanici> Html { get; private set; }
    }
}
#pragma warning restore 1591
