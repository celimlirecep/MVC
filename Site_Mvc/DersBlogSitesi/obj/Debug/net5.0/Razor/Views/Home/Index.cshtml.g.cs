#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c3e3231f862b547a3dfffc42e07974e2b06540bc"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c3e3231f862b547a3dfffc42e07974e2b06540bc", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DersBlogSitesi.Models.Makale>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"container-fluid  nav-bar-top\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml"
          
            foreach (var makaleler in Model)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-sm-6\">\r\n                    <div class=\"card mt-4\">\r\n                        <div class=\"card-body\">\r\n                            <h5 class=\"card-title\">");
#nullable restore
#line 12 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml"
                                              Write(makaleler.Header);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 12 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml"
                                                                Write(makaleler.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                            <p class=\"card-text\">\r\n                                ");
#nullable restore
#line 14 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml"
                           Write(makaleler.Content);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </p>\r\n                            <a href=\"MakaleIcerik\" class=\"btn btn-primary\">Git</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 20 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Home\Index.cshtml"

            };
        

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DersBlogSitesi.Models.Makale>> Html { get; private set; }
    }
}
#pragma warning restore 1591
