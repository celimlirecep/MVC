#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\WEB_Class_Projects\Haber_sitesi\mvc\HaberSitesi\HaberSitesi\Views\Kitap\KitapDetay.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d508f3db8df94d1223bee7330565f92be7899c7d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Kitap_KitapDetay), @"mvc.1.0.view", @"/Views/Kitap/KitapDetay.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d508f3db8df94d1223bee7330565f92be7899c7d", @"/Views/Kitap/KitapDetay.cshtml")]
    public class Views_Kitap_KitapDetay : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\recep\OneDrive\Masaüstü\WEB_Class_Projects\Haber_sitesi\mvc\HaberSitesi\HaberSitesi\Views\Kitap\KitapDetay.cshtml"
   
    HaberSitesi.Models.Kitaplar kitap = ViewBag.Kitap;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div>\r\n    <tr>\r\n        <td>");
#nullable restore
#line 8 "C:\Users\recep\OneDrive\Masaüstü\WEB_Class_Projects\Haber_sitesi\mvc\HaberSitesi\HaberSitesi\Views\Kitap\KitapDetay.cshtml"
       Write(kitap.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n        <td>");
#nullable restore
#line 9 "C:\Users\recep\OneDrive\Masaüstü\WEB_Class_Projects\Haber_sitesi\mvc\HaberSitesi\HaberSitesi\Views\Kitap\KitapDetay.cshtml"
       Write(kitap.KitapAdi);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</td>
    </tr>
    <h1>İçerik</h1>
    <p>Lorem ipsum dolor sit amet, consectetur adipisicing elit. Beatae porro, ut omnis quas perspiciatis, dolorem aspernatur minus quam tempora maxime debitis? Suscipit tempore iusto officiis cum natus! Illo, expedita aperiam!</p>
</div>
");
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
