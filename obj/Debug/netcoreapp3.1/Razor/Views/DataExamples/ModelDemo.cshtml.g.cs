#pragma checksum "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ModelDemo.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aacfb70783cd269cfe62a9b0d48e8980c7b17186"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_DataExamples_ModelDemo), @"mvc.1.0.view", @"/Views/DataExamples/ModelDemo.cshtml")]
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
#line 1 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\_ViewImports.cshtml"
using justAPlayMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\_ViewImports.cshtml"
using justAPlayMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aacfb70783cd269cfe62a9b0d48e8980c7b17186", @"/Views/DataExamples/ModelDemo.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3970c8783e66ba9e19e6f841a11ba7ce50d43a", @"/Views/_ViewImports.cshtml")]
    public class Views_DataExamples_ModelDemo : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<justAPlayMVC.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ModelDemo.cshtml"
    ViewData["Title"] = "Model Demo";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Data Retrieved from a Model</h2>\r\n\r\n<table class=\"tableData\">\r\n    <tr>\r\n        <td>BookTitle:</td>\r\n        <td>");
#nullable restore
#line 11 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ModelDemo.cshtml"
       Write(Model.BookTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n    <tr>\r\n        <td>BookAuthor:</td>\r\n        <td>");
#nullable restore
#line 15 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\DataExamples\ModelDemo.cshtml"
       Write(Model.BookAuthor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    </tr>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<justAPlayMVC.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
