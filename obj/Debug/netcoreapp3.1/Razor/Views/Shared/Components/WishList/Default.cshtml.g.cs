#pragma checksum "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\Shared\Components\WishList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ae2df6a7090d0310de1267476f7fa5f7b575f48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WishList_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WishList/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ae2df6a7090d0310de1267476f7fa5f7b575f48", @"/Views/Shared/Components/WishList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3970c8783e66ba9e19e6f841a11ba7ce50d43a", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WishList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"wishList\">\r\n    <h3>Wish List</h3>\r\n    <p>This is a sample component.</p>\r\n    <p>These are useful for features like Shopping Carts with reusable rendering logic.</p>\r\n    <p>");
#nullable restore
#line 5 "C:\Users\LabStudent-55-501897\Source\Repos\mvc-techniques-demo\Views\Shared\Components\WishList\Default.cshtml"
  Write(ViewBag.WishListFilim);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n </div>");
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
