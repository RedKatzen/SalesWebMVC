#pragma checksum "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "79ae50739cbd0d896eaf29ca697322e4dff1d369ef414ea1bf3137bdd34019e6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_About), @"mvc.1.0.view", @"/Views/Home/About.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/About.cshtml", typeof(AspNetCore.Views_Home_About))]
namespace AspNetCore
{
    #line default
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC

    ;
#line 2 "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\_ViewImports.cshtml"
using SalesWebMVC.Models

#line default
#line hidden
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"79ae50739cbd0d896eaf29ca697322e4dff1d369ef414ea1bf3137bdd34019e6", @"/Views/Home/About.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"c06ff15e14ca265ac02581f11c2f1df170b78788319fee00ba39468599e4f228", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_About : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
  
    ViewData["Title"] = "About";

#line default
#line hidden

            BeginContext(41, 4, true);
            WriteLiteral("<h2>");
            EndContext();
            BeginContext(46, 17, false);
            Write(
#line 4 "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
     ViewData["Title"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(63, 11, true);
            WriteLiteral("</h2>\r\n<h3>");
            EndContext();
            BeginContext(75, 19, false);
            Write(
#line 5 "C:\Users\gabri\Aula\dev\Udemy\csharp-oo\SalesWebMVC\SalesWebMVC\Views\Home\About.cshtml"
     ViewData["Message"]

#line default
#line hidden
            );
            EndContext();
            BeginContext(94, 66, true);
            WriteLiteral("</h3>\r\n\r\n<p>Use this area to provide additional information.</p>\r\n");
            EndContext();
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
