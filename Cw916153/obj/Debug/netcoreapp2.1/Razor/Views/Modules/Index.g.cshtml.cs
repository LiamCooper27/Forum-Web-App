#pragma checksum "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "921cf0575678574e6256eb8e990e8e7fdda9f81a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Modules_Index), @"mvc.1.0.view", @"/Views/Modules/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Modules/Index.cshtml", typeof(AspNetCore.Views_Modules_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"921cf0575678574e6256eb8e990e8e7fdda9f81a", @"/Views/Modules/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03efef9eb0689df19f336ba654272bdf4081d682", @"/Views/_ViewImports.cshtml")]
    public class Views_Modules_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Cw916153.Models.Module>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(87, 20, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n");
            EndContext();
            BeginContext(158, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 11 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
 if(User.IsInRole("canUseModuleControls"))
{

#line default
#line hidden
            BeginContext(207, 17, true);
            WriteLiteral("    <p>\r\n        ");
            EndContext();
            BeginContext(224, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "318b30f90a454ef09b87a9b81ff0e68f", async() => {
                BeginContext(247, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(261, 12, true);
            WriteLiteral("\r\n    </p>\r\n");
            EndContext();
#line 16 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
}

#line default
#line hidden
            BeginContext(276, 86, true);
            WriteLiteral("\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(363, 40, false);
#line 22 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(403, 39, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n");
            EndContext();
#line 25 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                 if (User.IsInRole("canUseModuleControls"))
                {

#line default
#line hidden
            BeginContext(522, 92, true);
            WriteLiteral("                    <p>\r\n                        Module Controls\r\n                    </p>\r\n");
            EndContext();
#line 30 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                }

#line default
#line hidden
            BeginContext(633, 74, true);
            WriteLiteral("            </th>\r\n           \r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 36 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(739, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(788, 39, false);
#line 39 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
            EndContext();
            BeginContext(827, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(883, 56, false);
#line 42 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
           Write(Html.ActionLink("View", "Details", new { id = item.Id }));

#line default
#line hidden
            EndContext();
            BeginContext(939, 6, true);
            WriteLiteral(" |\r\n\r\n");
            EndContext();
#line 44 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                 if (User.IsInRole("canUseModuleControls"))
                {
                    

#line default
#line hidden
            BeginContext(1046, 53, false);
#line 46 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.Id }));

#line default
#line hidden
            EndContext();
#line 46 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                                                                          
                }

#line default
#line hidden
            BeginContext(1120, 19, true);
            WriteLiteral("                |\r\n");
            EndContext();
#line 49 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                 if (User.IsInRole("canUseModuleControls"))
                {
                    

#line default
#line hidden
            BeginContext(1240, 57, false);
#line 51 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
               Write(Html.ActionLink("Delete", "Delete", new { id = item.Id }));

#line default
#line hidden
            EndContext();
#line 51 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
                                                                              
                }

#line default
#line hidden
            BeginContext(1318, 34, true);
            WriteLiteral("            </td>\r\n        </tr>\r\n");
            EndContext();
#line 55 "C:\Users\Liam Cooper\Desktop\v2\Cw916153\Cw916153\Views\Modules\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1355, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Cw916153.Models.Module>> Html { get; private set; }
    }
}
#pragma warning restore 1591
