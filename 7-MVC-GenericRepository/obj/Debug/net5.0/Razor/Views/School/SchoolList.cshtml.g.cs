#pragma checksum "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\School\SchoolList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3746dea11508e01867c3169f1a8b6f948e191718"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_School_SchoolList), @"mvc.1.0.view", @"/Views/School/SchoolList.cshtml")]
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
#line 1 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\_ViewImports.cshtml"
using _7_MVC_GenericRepository;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\_ViewImports.cshtml"
using _7_MVC_GenericRepository.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\_ViewImports.cshtml"
using _7_MVC_GenericRepository.Entities.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3746dea11508e01867c3169f1a8b6f948e191718", @"/Views/School/SchoolList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ab899f54d647350a7cea378079a85549f50bc3f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_School_SchoolList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<School>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\School\SchoolList.cshtml"
  
    ViewData["Title"] = "Schools";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <h1>School Index</h1>\r\n\r\n\r\n<br />\r\n\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>Name</th>\r\n    </tr>\r\n");
#nullable restore
#line 15 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\School\SchoolList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\School\SchoolList.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 20 "C:\Users\Asena Sevnur Ulun\Desktop\Robereattığım\7-MVC-GenericRepository\7-MVC-GenericRepository\Views\School\SchoolList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<School>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
