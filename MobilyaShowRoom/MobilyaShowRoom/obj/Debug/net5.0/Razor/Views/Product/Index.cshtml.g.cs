#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53ed1d736e8b31328ca73cd451e3df9cc890dc1a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53ed1d736e8b31328ca73cd451e3df9cc890dc1a", @"/Views/Product/Index.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<MobilyaShowRoom.Models.Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
  
    Layout = "_Layout";
    ViewBag.title = "Products";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<div class=\"d-flex row justify-content-lg-between  w-100 mx-auto bg-info\">\r\n");
#nullable restore
#line 11 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""col-4 my-3 d-flex justify-content-center "" >
        <div class=""card  "" style=""width: 18rem; border:8px dashed blue"">
            <div class=""card-body"">
                <h5 class=""card-title"" style=""padding-left:100px;background-color:burlywood"">");
#nullable restore
#line 18 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
                                                                                        Write(product.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <hr />\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 20 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
                                  Write(product.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <hr />\r\n                <p class=\"card-text\">");
#nullable restore
#line 22 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
                                Write(product.ProductDetail);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <hr />\r\n                <h2 class=\"text-danger\" style=\"padding-left:80px\">");
#nullable restore
#line 24 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
                                                             Write(product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("$</h2>\r\n                <hr />\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 860, "\"", 903, 2);
            WriteAttributeValue("", 867, "product/getproductdetail/", 867, 25, true);
#nullable restore
#line 26 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
WriteAttributeValue("", 892, product.ID, 892, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"nav-link text-success  border-3 rounded fs-1\" style=\"padding-left:80px\">Detay</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 30 "C:\Users\recep\OneDrive\Masaüstü\mvc\MobilyaShowRoom\mobilyashowroom\Views\Product\Index.cshtml"
       
  




}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<MobilyaShowRoom.Models.Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
