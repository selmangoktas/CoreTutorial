#pragma checksum "D:\calismalar\CoreTutorial\StaticFileApp\Views\Home\Album.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ac6f0381a2b5c815757864b277e973d0d640fad0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Album), @"mvc.1.0.view", @"/Views/Home/Album.cshtml")]
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
#line 1 "D:\calismalar\CoreTutorial\StaticFileApp\Views\_ViewImports.cshtml"
using StaticFileApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\calismalar\CoreTutorial\StaticFileApp\Views\_ViewImports.cshtml"
using StaticFileApp.Tools;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac6f0381a2b5c815757864b277e973d0d640fad0", @"/Views/Home/Album.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"590316fb0112288490161904158c8a780abf62dd", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Album : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\calismalar\CoreTutorial\StaticFileApp\Views\Home\Album.cshtml"
  
    ViewData["Title"] = "Album";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Album</h1>\r\n\r\n\r\n<div class=\"row row-cols-1 row-cols-sm-2 row-cols-md-3 g-3\">\r\n\r\n");
#nullable restore
#line 12 "D:\calismalar\CoreTutorial\StaticFileApp\Views\Home\Album.cshtml"
     for (int i = 0; i < 9; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col"">
            <div class=""card shadow-sm"">
                <svg class=""bd-placeholder-img card-img-top"" width=""100%"" height=""225"" xmlns=""http://www.w3.org/2000/svg"" role=""img"" aria-label=""Placeholder: Thumbnail"" preserveAspectRatio=""xMidYMid slice"" focusable=""false""><title>Placeholder</title><rect width=""100%"" height=""100%"" fill=""#55595c"" /><text x=""50%"" y=""50%"" fill=""#eceeef"" dy="".3em"">Thumbnail</text></svg>

                <div class=""card-body"">
                    <p class=""card-text"">This is a wider card with supporting text below as a natural lead-in to additional content. This content is a little bit longer.</p>
                    <div class=""d-flex justify-content-between align-items-center"">
                        <div class=""btn-group"">
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">View</button>
                            <button type=""button"" class=""btn btn-sm btn-outline-secondary"">Edit</button>
                    ");
            WriteLiteral("    </div>\r\n                        <small class=\"text-muted\">9 mins</small>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 30 "D:\calismalar\CoreTutorial\StaticFileApp\Views\Home\Album.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n</div>\r\n\r\n");
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
