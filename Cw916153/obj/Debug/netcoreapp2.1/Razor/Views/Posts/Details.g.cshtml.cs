#pragma checksum "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfd1f6ef93bc1c484da0b457ce91e070a2e44ef6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Details), @"mvc.1.0.view", @"/Views/Posts/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Posts/Details.cshtml", typeof(AspNetCore.Views_Posts_Details))]
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
#line 1 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\_ViewImports.cshtml"
using Cw916153;

#line default
#line hidden
#line 2 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\_ViewImports.cshtml"
using Cw916153.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfd1f6ef93bc1c484da0b457ce91e070a2e44ef6", @"/Views/Posts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03efef9eb0689df19f336ba654272bdf4081d682", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Cw916153.Models.PostCommentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ajax-unobtrusive/jquery.unobtrusive-ajax.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(45, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
            BeginContext(86, 98, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Post</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(185, 46, false);
#line 12 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Title));

#line default
#line hidden
            EndContext();
            BeginContext(231, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(277, 42, false);
#line 16 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Post.Title));

#line default
#line hidden
            EndContext();
            BeginContext(319, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(365, 48, false);
#line 20 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.Content));

#line default
#line hidden
            EndContext();
            BeginContext(413, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(459, 44, false);
#line 24 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Post.Content));

#line default
#line hidden
            EndContext();
            BeginContext(503, 45, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(549, 56, false);
#line 28 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Post.CreatedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(605, 45, true);
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(651, 52, false);
#line 32 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Post.CreatedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(703, 19, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n");
            EndContext();
#line 35 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
         if (User.IsInRole("canUsePostControls"))
        {

#line default
#line hidden
            BeginContext(784, 106, true);
            WriteLiteral("            <dt>\r\n                Change this Post:\r\n            </dt>\r\n            <dd>\r\n                ");
            EndContext();
            BeginContext(891, 74, false);
#line 41 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
           Write(Html.ActionLink("Edit", "Edit", "Posts", new { id = Model.Post.Id }, null));

#line default
#line hidden
            EndContext();
            BeginContext(965, 21, true);
            WriteLiteral("\r\n            </dd>\r\n");
            EndContext();
#line 43 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(997, 199, true);
            WriteLiteral("\r\n    </dl>\r\n</div>\r\n\r\n<h4>Comments</h4>\r\n<button id=\"btnShowHide\" type=\"button\" class=\"btn btn-default\">Show/Hide Comments</button>\r\n<hr />\r\n<div id=\"commentTableDiv\">\r\n    <table class=\"table\">\r\n\r\n");
            EndContext();
#line 54 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
         foreach (var item in Model.Comments)
        {

#line default
#line hidden
            BeginContext(1254, 18, true);
            WriteLiteral("            <tr>\r\n");
            EndContext();
#line 57 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                 if (item.IsAnon == true)
                {

#line default
#line hidden
            BeginContext(1334, 88, true);
            WriteLiteral("                    <th>\r\n                        Anonymous\r\n                    </th>\r\n");
            EndContext();
#line 62 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1482, 50, true);
            WriteLiteral("                    <th>\r\n                        ");
            EndContext();
            BeginContext(1533, 39, false);
#line 66 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.User));

#line default
#line hidden
            EndContext();
            BeginContext(1572, 29, true);
            WriteLiteral("\r\n                    </th>\r\n");
            EndContext();
#line 68 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                }

#line default
#line hidden
            BeginContext(1620, 42, true);
            WriteLiteral("                <th>\r\n                    ");
            EndContext();
            BeginContext(1663, 50, false);
#line 70 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.CreatedDateTime));

#line default
#line hidden
            EndContext();
            BeginContext(1713, 122, true);
            WriteLiteral("\r\n                </th>\r\n            </tr>\r\n            <tr id=\"comment-body\">\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1836, 42, false);
#line 75 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
               Write(Html.DisplayFor(modelItem => item.Content));

#line default
#line hidden
            EndContext();
            BeginContext(1878, 69, true);
            WriteLiteral("\r\n                </td>\r\n                <td id=\"comment-controls\">\r\n");
            EndContext();
#line 78 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                     if (User.IsInRole("canUsePostControls"))
                    {
                        

#line default
#line hidden
            BeginContext(2058, 71, false);
#line 80 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                   Write(Html.ActionLink("Edit", "Edit", "Comments", new { id = item.Id }, null));

#line default
#line hidden
            EndContext();
#line 80 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                                                                                                
                    }

#line default
#line hidden
            BeginContext(2154, 23, true);
            WriteLiteral("                    |\r\n");
            EndContext();
#line 83 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                     if (User.IsInRole("canUsePostControls"))
                    {
                        

#line default
#line hidden
            BeginContext(2288, 75, false);
#line 85 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                   Write(Html.ActionLink("Delete", "Delete", "Comments", new { id = item.Id }, null));

#line default
#line hidden
            EndContext();
#line 85 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                                                                                                    
                    }

#line default
#line hidden
            BeginContext(2388, 44, true);
            WriteLiteral("                </td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 90 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
        }

#line default
#line hidden
            BeginContext(2443, 28, true);
            WriteLiteral("\r\n    </table>\r\n\r\n</div>\r\n\r\n");
            EndContext();
#line 96 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
 if (User.IsInRole("canCreateComment") || User.IsInRole("canUsePostControls"))
{
    

#line default
#line hidden
#line 98 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(2601, 23, false);
#line 100 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(2628, 107, true);
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>New Comment</h4>\r\n            <hr />\r\n\r\n            ");
            EndContext();
            BeginContext(2736, 64, false);
#line 106 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2800, 50, true);
            WriteLiteral("\r\n\r\n            <input type=\"hidden\" name=\"PostId\"");
            EndContext();
            BeginWriteAttribute("value", " value=\"", 2850, "\"", 2872, 1);
#line 108 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
WriteAttributeValue("", 2858, Model.Post.Id, 2858, 14, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2873, 61, true);
            WriteLiteral(" />\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2935, 96, false);
#line 111 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
           Write(Html.LabelFor(model => model.Content, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3031, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(3095, 96, false);
#line 113 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
               Write(Html.EditorFor(model => model.Content, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3191, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3214, 85, false);
#line 114 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
               Write(Html.ValidationMessageFor(model => model.Content, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3299, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(3402, 95, false);
#line 119 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
           Write(Html.LabelFor(model => model.IsAnon, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3497, 111, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    <div class=\"checkbox\">\r\n                        ");
            EndContext();
            BeginContext(3609, 37, false);
#line 122 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                   Write(Html.EditorFor(model => model.IsAnon));

#line default
#line hidden
            EndContext();
            BeginContext(3646, 26, true);
            WriteLiteral("\r\n                        ");
            EndContext();
            BeginContext(3673, 84, false);
#line 123 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
                   Write(Html.ValidationMessageFor(model => model.IsAnon, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3757, 315, true);
            WriteLiteral(@"
                    </div>
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Create"" class=""btn btn-default"" />
                </div>
            </div>
        </div>
");
            EndContext();
#line 134 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
    }

#line default
#line hidden
#line 134 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
     
}

#line default
#line hidden
            BeginContext(4082, 13, true);
            WriteLiteral("\r\n<div>\r\n    ");
            EndContext();
            BeginContext(4096, 95, false);
#line 138 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Posts\Details.cshtml"
Write(Html.ActionLink("Back to Module", "Details", "Modules", new { id = Model.Post.ModuleId }, null));

#line default
#line hidden
            EndContext();
            BeginContext(4191, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4221, 8, true);
                WriteLiteral("\r\n\r\n    ");
                EndContext();
                BeginContext(4229, 84, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b6c1f4f0c5654acabedb99043088bdff", async() => {
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
                EndContext();
                BeginContext(4313, 231, true);
                WriteLiteral("\r\n    <script type=\"text/javascript\">\r\n\r\n        $(document).ready(function () {\r\n            $(\"#btnShowHide\").click(function () {\r\n                $(\'#commentTableDiv\').toggle();\r\n            });\r\n\r\n        });\r\n\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(4547, 2, true);
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Cw916153.Models.PostCommentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
