#pragma checksum "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e84936e251ca6454a518b2614ffdb21a10b6159"
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
#nullable restore
#line 1 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\_ViewImports.cshtml"
using slots;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\_ViewImports.cshtml"
using slots.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Configuration;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e84936e251ca6454a518b2614ffdb21a10b6159", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8aae12c5d9eeaf6066cf898d42c40e10991c35bd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"text-center\"");
            BeginWriteAttribute("style", " style=\"", 69, "\"", 111, 3);
            WriteAttributeValue("", 77, "background-color:", 77, 17, true);
#nullable restore
#line 4 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml"
WriteAttributeValue(" ", 94, Conf["colour"], 95, 15, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 110, ";", 110, 1, true);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <h1 class=\"display-4\">Welcome the ");
#nullable restore
#line 5 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml"
                                 Write(Conf["site"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(" site</h1>\r\n    <dl class=\"text-left\">\r\n        <dt>DB connection string</dt>\r\n        <dd>");
#nullable restore
#line 8 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml"
       Write(Conf["dbconn"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n\r\n        <dt>Auth URL string</dt>\r\n        <dd>");
#nullable restore
#line 11 "D:\OneDrive - Microsoft\Documents\Repos\az-slots-net31\Views\Home\Index.cshtml"
       Write(Conf["auth"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n    </dl>\r\n</div>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IConfiguration Conf { get; private set; }
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
