#pragma checksum "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4ed32f4c898699e2d50fbf064ae74970d246709c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Details), @"mvc.1.0.view", @"/Views/Employee/Details.cshtml")]
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
#line 1 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\_ViewImports.cshtml"
using HrSystem;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\_ViewImports.cshtml"
using HrSystem.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\_ViewImports.cshtml"
using HrSystem.ViewModel;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ed32f4c898699e2d50fbf064ae74970d246709c", @"/Views/Employee/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8bbe3ac46e81062aeef8a23f7c23733698b451f9", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GraduationProject.Models.Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success my-5 mx-2 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("Edit()"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger my-5 "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 col-md-12 col-lg-12\">\r\n        <h1 class=\"p-4 my-2\">\r\n            <img class=\"mx-3\" src=\"https://img.icons8.com/ios-filled/50/000000/men-age-group-5.png\" />");
#nullable restore
#line 8 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                                                                                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </h1>\r\n        <hr />\r\n    </div>\r\n</div>\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 col-lg-6 col-md-6\">\r\n\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 18 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\"> ");
#nullable restore
#line 19 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\"> ");
#nullable restore
#line 22 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 23 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 26 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 27 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Gender));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 30 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 31 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 34 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.BirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 35 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.BirthDay));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 38 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 39 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Nationality));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 42 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.NationalityID));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 43 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.NationalityID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n\r\n    </div>\r\n    <div class=\"col-sm-12 col-md-6 col-lg-6\">\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 49 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.ContractDate));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 50 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.ContractDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 53 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.AttendanceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 54 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.AttendanceTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 57 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.LeavingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 58 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.LeavingTime));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 61 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 62 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Salary));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n        <div class=\"p-2\">\r\n            <label class=\"h5\">");
#nullable restore
#line 65 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                         Write(Html.DisplayNameFor(model => model.Dept));

#line default
#line hidden
#nullable disable
            WriteLiteral(":</label>\r\n            <span class=\"fs-5\">");
#nullable restore
#line 66 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                          Write(Html.DisplayFor(model => model.Dept.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n<div class=\"row\">\r\n    <div class=\"col-sm-12 col-md-12 col-lg-12 d-flex justify-content-center \">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed32f4c898699e2d50fbf064ae74970d246709c14484", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 74 "D:\ITI .NET\Final Project\our project\HrSystemN\HrSystem\HrSystem\Views\Employee\Details.cshtml"
                                                                                   WriteLiteral(Model.ID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4ed32f4c898699e2d50fbf064ae74970d246709c16867", async() => {
                WriteLiteral("Back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n\r\n\r\n</div>\r\n<script>\r\n    function Edit() {\r\n        var respond = confirm(\"Do you want to Edit ?!\");\r\n        if (!respond) {\r\n            event.preventDefault();\r\n        }\r\n    }\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GraduationProject.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
