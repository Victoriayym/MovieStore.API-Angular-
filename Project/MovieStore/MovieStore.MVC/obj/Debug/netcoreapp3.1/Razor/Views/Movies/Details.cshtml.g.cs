#pragma checksum "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "187396b11eac70a81f124dd7a1a1a34c7a9e6532"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Details), @"mvc.1.0.view", @"/Views/Movies/Details.cshtml")]
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
#nullable restore
#line 2 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
using System.Globalization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"187396b11eac70a81f124dd7a1a1a34c7a9e6532", @"/Views/Movies/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09aa387f5e615eecbf69936df9de009cac81cba1", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieStore.Core.Entities.Movie>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", "~/js/site.js", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFavorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "User", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Favorite", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("button"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn-primary btn"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-target", new global::Microsoft.AspNetCore.Html.HtmlString("#reviewModal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("data-toggle", new global::Microsoft.AspNetCore.Html.HtmlString("modal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Review", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Purchase", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e65328235", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e65329274", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e653210313", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ScriptTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.Src = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
#nullable restore
#line 6 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ScriptTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"row text-light bg-dark\">\r\n    <div class=\"col-4\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 338, "\"", 360, 1);
#nullable restore
#line 10 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 344, Model.PosterUrl, 344, 16, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 361, "\"", 379, 1);
#nullable restore
#line 10 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 367, Model.Title, 367, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"250\" />\r\n    </div>\r\n    <div class=\"col-6\">\r\n        <h1>");
#nullable restore
#line 13 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
       Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n        <div><small>");
#nullable restore
#line 14 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
               Write(Model.Tagline);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></div>\r\n        <div><label>");
#nullable restore
#line 15 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
               Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral(" m | ");
#nullable restore
#line 15 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                  Write(Model.ReleaseDate?.ToString("yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</label></div>\r\n        <div>\r\n");
#nullable restore
#line 17 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
             foreach (var item in Model.MovieGenres)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <span class=\"badge badge-secondary\">");
#nullable restore
#line 19 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                               Write(item.Genre.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 20 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n        <div><span class=\"badge badge-warning\">");
#nullable restore
#line 22 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                          Write(Model.Reviews.Average(r => r.Rating).ToString("F"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <p><small>");
#nullable restore
#line 23 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
             Write(Model.Overview);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n    </div>\r\n    <div class=\"col-2\">\r\n        \r\n                <button type=\"button\" class=\"btn-primary btn\">\r\n                 Trailer\r\n                </button>\r\n        \r\n");
#nullable restore
#line 31 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
         if (ViewBag.Favorited)
        {


#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e653216259", async() => {
                WriteLiteral("\r\n                 <button style=\"color:red\" type=\"submit\" class=\"btn-primary btn\">\r\n            <i class=\"fas fa-heart\"></i>\r\n            </button>\r\n             <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1444, "\"", 1461, 1);
#nullable restore
#line 38 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1452, Model.Id, 1452, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n");
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 41 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e653219018", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                    <button style=\"color:floralwhite\" type=\"submit\" class=\"btn-primary btn\">\r\n                        <i class=\"fas fa-heart\"></i>\r\n                    </button>\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 1910, "\"", 1927, 1);
#nullable restore
#line 49 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 1918, Model.Id, 1918, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n");
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 52 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e653221821", async() => {
                WriteLiteral("\r\n            Review\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Action = (string)__tagHelperAttribute_11.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_11);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
         if (ViewBag.Purchased)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("<span class=\"badge badge-secondary\"><button>Watch Movie</button></span>");
#nullable restore
#line 61 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                                                      

        }
        else
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "187396b11eac70a81f124dd7a1a1a34c7a9e653224317", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("                    <input type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 2579, "\"", 2603, 2);
                WriteAttributeValue("", 2587, "BUY", 2587, 3, true);
#nullable restore
#line 68 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue(" ", 2590, Model.Price, 2591, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2673, "\"", 2690, 1);
#nullable restore
#line 69 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 2681, Model.Id, 2681, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"MovieId\" />\r\n");
                WriteLiteral("            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_12.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_12);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 72 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 col-md-5\">\r\n        <h3>Movie Facts</h3>\r\n        <div class=\"border-bottom\">Release Date <span class=\"badge badge-secondary\">");
#nullable restore
#line 79 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                               Write(Model.ReleaseDate?.ToString("MMM dd, yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <div class=\"border-bottom\">Run Time <span class=\"badge badge-secondary\">");
#nullable restore
#line 80 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                           Write(Model.RunTime);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <div class=\"border-bottom\">Box Office <span class=\"badge badge-secondary\">");
#nullable restore
#line 81 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                             Write(Model.Revenue?.ToString("C3", CultureInfo.CurrentCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span></div>\r\n        <div class=\"border-bottom\">Budget <span class=\"badge badge-secondary\">");
#nullable restore
#line 82 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                                                                         Write(Model.Budget?.ToString("C3", CultureInfo.CurrentCulture));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span></div>
    </div>
    <div class=""col-sm-12 col-md-7"">
        <h3>Cast</h3>
        <div class=""row"">
            <div class=""col-sm-4"">
                Profile
            </div>
            <div class=""col-sm-4"">
                Actor
            </div>
            <div class=""col-sm-4"">
                Character
            </div>
        </div>
");
#nullable restore
#line 97 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
         foreach (var item in Model.MovieCasts)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a");
            BeginWriteAttribute("href", " href=\"", 3883, "\"", 3908, 1);
#nullable restore
#line 99 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 3890, item.Cast.TmdbUrl, 3890, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-4\">\r\n");
#nullable restore
#line 102 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                         if (string.IsNullOrEmpty(item.Cast.ProfilePath))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>");
#nullable restore
#line 104 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                             Write(item.Cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n");
#nullable restore
#line 105 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <img height=\"75\"");
            BeginWriteAttribute("src", " src=\"", 4279, "\"", 4307, 1);
#nullable restore
#line 108 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 4285, item.Cast.ProfilePath, 4285, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 4308, "\"", 4329, 1);
#nullable restore
#line 108 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
WriteAttributeValue("", 4314, item.Cast.Name, 4314, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n");
#nullable restore
#line 109 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-sm-4\">\r\n                        <span>");
#nullable restore
#line 113 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                         Write(item.Cast.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                    <div class=\"col-sm-4\">\r\n                        <span>");
#nullable restore
#line 116 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
                         Write(item.Character);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                    </div>\r\n                </div>\r\n            </a>\r\n");
#nullable restore
#line 120 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n    <div id=\"reviewModal\" role=\"dialog\" class=\"modal fade\">\r\n        <div class=\"modal-dialog\">\r\n            ");
#nullable restore
#line 124 "C:\Users\dell\Documents\GitHub\ASP.NET\Project\MovieStore\MovieStore.MVC\Views\Movies\Details.cshtml"
       Write(Html.Partial("_Review", Model));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieStore.Core.Entities.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
