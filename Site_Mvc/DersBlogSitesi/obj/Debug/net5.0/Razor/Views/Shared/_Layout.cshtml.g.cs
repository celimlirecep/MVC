#pragma checksum "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eaffaeb5e34bf5942de831c3b1fa3c0cb309c156"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eaffaeb5e34bf5942de831c3b1fa3c0cb309c156", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"tr\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaffaeb5e34bf5942de831c3b1fa3c0cb309c1562748", async() => {
                WriteLiteral(@"
    <meta charset=""UTF-8"">
    <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>MVC Proje_1</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css"" rel=""stylesheet"" integrity=""sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3"" crossorigin=""anonymous"">
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/js/bootstrap.bundle.min.js"" integrity=""sha384-ka7Sk0Gln4gmtz2MlQnikT1wXgYsOg+OMhuP+IlRH9sENBO0LRn5q+8nbTov4+1p"" crossorigin=""anonymous""></script>
    <style>
        .nav-bar-top {
            background-color: rgb(34, 47, 62);
        }

        a:hover {
            background-color: rgb(16, 172, 132);
            border-radius: 5%;
            color: rgb(3, 14, 34) !important;
        }
    </style>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eaffaeb5e34bf5942de831c3b1fa3c0cb309c1564637", async() => {
                WriteLiteral(@"
    <!-- ---------------------------------Baslik kısmı------------------------------------------------- -->
    <header>
        <nav class=""navbar fixed-top navbar-expand-lg navbar-light nav-bar-top "">
            <div class=""container-fluid"">
                <a class=""navbar-brand text-white fs-3 bg-danger px-3 rounded"" href=""#"">Wissen Blog</a>
                <button class=""navbar-toggler"" type=""button"" data-bs-toggle=""collapse""
                        data-bs-target=""#navbarSupportedContent"" aria-controls=""navbarSupportedContent""
                        aria-expanded=""false"" aria-label=""Toggle navigation"">
                    <span class=""navbar-toggler-icon""></span>
                </button>
                <div class=""collapse navbar-collapse "" id=""navbarSupportedContent"">
                    <ul class=""navbar-nav me-auto mb-2 mb-lg-0  px-5"">
                        <li class=""nav-item"">
                            <a class=""nav-link active text-white fs-5"" aria-current=""page"" href=""#"">An");
                WriteLiteral(@"asayfa</a>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link text-white fs-5"" href=""#"">Hakkımızda</a>
                        </li>
                        <li class=""nav-item dropdown"">
                            <a class=""nav-link dropdown-toggle text-white fs-5"" href=""#"" id=""navbarDropdown""
                               role=""button"" data-bs-toggle=""dropdown"" aria-expanded=""false"">
                                Dersler
                            </a>
                            <ul class=""dropdown-menu"" aria-labelledby=""navbarDropdown"">
                                <li><a class=""dropdown-item "" href=""#"">C#</a></li>
                                <li><a class=""dropdown-item "" href=""#"">JAVASCRİPT</a></li>
                                <li><a class=""dropdown-item "" href=""#"">HTML</a></li>
                                <li><a class=""dropdown-item "" href=""#"">CSS</a></li>
                                <li><a cla");
                WriteLiteral(@"ss=""dropdown-item "" href=""#"">BOOTSTRAP</a></li>
                                <li><a class=""dropdown-item "" href=""#"">JQUERY</a></li>
                                <li><a class=""dropdown-item "" href=""#"">REACT</a></li>
                                <li>
                                    <hr class=""dropdown-divider"">
                                </li>
                                <li><a class=""dropdown-item "" href=""#"">OOP</a></li>
                                <li><a class=""dropdown-item "" href=""#"">PHP</a></li>
                            </ul>
                        </li>
                        <li class=""nav-item"">
                            <a class=""nav-link disabled text-white fs-5 "" href=""#"">İletişim</a>
                        </li>
                    </ul>
                    <form class=""d-flex"">
                        <input class=""form-control me-2"" type=""search"" placeholder=""Search"" aria-label=""Search"">
                        <button class=""btn btn-outline-light ");
                WriteLiteral(@""" type=""submit"">Ara</button>
                    </form>
                </div>
            </div>
        </nav>
    </header>
    <!-- ---------------------------------Section Bölümü------------------------------------------------- -->
    <section class=""mt-5"">
        ");
#nullable restore
#line 77 "C:\Users\recep\OneDrive\Masaüstü\mvc\Site_Mvc\DersBlogSitesi\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
    </section>
    <!-- ---------------------------------Footer Bölümü------------------------------------------------- -->
    <footer>
        <div class=""container-fluid nav-bar-top text-white text-center py-3"">
            <hr>
            <p>Wissen Academia 2022</p>

        </div>

    </footer>



    <!-- ----------------------------Script Kodları------------------------------------------------------ -->
    <script src=""script.js""></script>
    <script src=""./js/bootstrap.bundle.min.js""></script>
    <script src=""./js/jquery-3.6.0.min.js""></script>
    <!-- ----------------------------Script Kodları Bitis------------------------------------------------------ -->
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</html>\r\n");
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
