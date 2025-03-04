#pragma checksum "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dbb6a50a606a4f0f90f4c69bfdebb0043a144714"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Artworks_Index), @"mvc.1.0.view", @"/Views/Artworks/Index.cshtml")]
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
#line 1 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\_ViewImports.cshtml"
using ArtShowSqlServer;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\_ViewImports.cshtml"
using ArtShowSqlServer.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dbb6a50a606a4f0f90f4c69bfdebb0043a144714", @"/Views/Artworks/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e2fab7f8e670e964c2c1ef7f7035082cdc606c20", @"/Views/_ViewImports.cshtml")]
    public class Views_Artworks_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
  

    var ArtWorks = (List<ArtWorksModel>)ViewData["ArtWorks"];

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"content-section-heading text-center\">\r\n    <br />\r\n\r\n    <h1 class=\"mb-5\" style=\"text-shadow: 2px 2px #000000;\">Art Works</h1>\r\n</div>\r\n<div class=\"container px-4 px-lg-5 \">\r\n\r\n    <div class=\"row row-cols-1 row-cols-md-2 g-4\">\r\n");
#nullable restore
#line 13 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
         foreach (var art in ArtWorks)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <div class=""col"" style=""padding-bottom:30px"">
                <div class=""card""
                     style=""width: 25rem; box-shadow: 5px 10px 18px #000000; 
                        background-color: rgb(0,0,0,0.5); align-items: center; "">
                    <div class=""card-body"" style=""align-items:center"">
                        <a class=""portfolio-item""");
            BeginWriteAttribute("href", " href=\"", 741, "\"", 773, 2);
            WriteAttributeValue("", 748, "/Artworks/Details/", 748, 18, true);
#nullable restore
#line 20 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
WriteAttributeValue("", 766, art.Id, 766, 7, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                            <img class=\"card-img-top\" style=\"width:250px; height:250px;\"");
            BeginWriteAttribute("src", " src=\"", 865, "\"", 881, 1);
#nullable restore
#line 21 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
WriteAttributeValue("", 871, art.Image, 871, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 882, "\"", 898, 1);
#nullable restore
#line 21 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
WriteAttributeValue("", 888, art.Image, 888, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div style=\"color:white; font-size:20px; text-align:center\"> ");
#nullable restore
#line 22 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
                                                                                    Write(art.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                        </a>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 27 "C:\Users\Shaha\source\repos\ArtShowSqlServer\ArtShowSqlServer\Views\Artworks\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n");
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
