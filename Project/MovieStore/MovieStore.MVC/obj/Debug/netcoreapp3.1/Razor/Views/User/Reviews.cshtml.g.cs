#pragma checksum "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\User\Reviews.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1c9bf05c03624bfb4da493a00c7c1e3979079d66"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Reviews), @"mvc.1.0.view", @"/Views/User/Reviews.cshtml")]
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
#line 1 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\_ViewImports.cshtml"
using MovieStore.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1c9bf05c03624bfb4da493a00c7c1e3979079d66", @"/Views/User/Reviews.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Reviews : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<MovieStore.Core.Entities.Review>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>\r\n        List of Reviews \r\n    </h1>\r\n   \r\n    <table class=\"table\">\r\n        <tr>\r\n            <th>Movie Name</th>\r\n            <th>Review Description</th>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 13 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\User\Reviews.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td>");
#nullable restore
#line 16 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\User\Reviews.cshtml"
       Write(item.Movie.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        <td>");
#nullable restore
#line 17 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\User\Reviews.cshtml"
       Write(item.ReviewText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\User\Reviews.cshtml"

            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n       \r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<MovieStore.Core.Entities.Review>> Html { get; private set; }
    }
}
#pragma warning restore 1591
