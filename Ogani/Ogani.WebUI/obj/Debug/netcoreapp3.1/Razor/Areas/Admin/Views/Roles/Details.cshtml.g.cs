#pragma checksum "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1ae9900b67c9a677d3e9c807b71597359b30ab4a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Ogani.WebUI.Views.Roles.Areas_Admin_Views_Roles_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Details.cshtml")]
namespace Ogani.WebUI.Views.Roles
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
#line 2 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.Application.Models.Entity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.Application.Models.Entity.Membership;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Areas.Admin.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.AppCode.Types;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.WebUI.Models.DataContext;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Ogani.Application.Extensions;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/_ViewImports.cshtml"
using Resource;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ae9900b67c9a677d3e9c807b71597359b30ab4a", @"/Areas/Admin/Views/Roles/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa0bbca5203c2ecdffcac8461b859c2b788b23ef", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Roles_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OganiRole>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("control-label"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
  
    ViewData["Title"] = "Role Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<ul class=\"breadcrumb\">\r\n    <li>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a7080", async() => {
                WriteLiteral("Admin");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </li>\r\n    <li>\r\n        <p>");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a8462", async() => {
                WriteLiteral("Roles");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</p>\r\n    </li>\r\n    <li><a class=\"active\">View</a> </li>\r\n</ul>\r\n<div class=\"page-title\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a9706", async() => {
                WriteLiteral("\r\n        <i class=\"far fa-arrow-alt-circle-left\"></i>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    <h3>Admin - Roles</h3>\r\n</div>\r\n\r\n\r\n<div class=\"row-fluid\">\r\n    <div class=\"span12\">\r\n        <div class=\"grid simple \">\r\n            <div class=\"grid-body \">\r\n                <div class=\"form-group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a11160", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#nullable restore
#line 29 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Name);

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <p class=\"form-control\">\r\n                        ");
#nullable restore
#line 31 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                   Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </p>\r\n                </div>\r\n                <div class=\"form-group\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a13154", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 35 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                   WriteLiteral(Model.Id);

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
            WriteLiteral("\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1ae9900b67c9a677d3e9c807b71597359b30ab4a15441", async() => {
                WriteLiteral("Back to list");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                </div>
            </div>

            <div class=""grid-body"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <ul class=""nav nav-tabs"" role=""tablist"">
                            <li class=""active"">
                                <a href=""#tabUsers"" role=""tab"" data-toggle=""tab"" aria-expanded=""true"">Users</a>
                            </li>
                            <li");
            BeginWriteAttribute("class", " class=\"", 1516, "\"", 1524, 0);
            EndWriteAttribute();
            WriteLiteral(@">
                                <a href=""#tabClaims"" role=""tab"" data-toggle=""tab"" aria-expanded=""false"">Claims</a>
                            </li>
                        </ul>
                        <div class=""tools"">
                            <a href=""javascript:;"" class=""collapse""></a>
                            <a href=""#grid-config"" data-toggle=""modal"" class=""config""></a>
                            <a href=""javascript:;"" class=""reload""></a>
                            <a href=""javascript:;"" class=""remove""></a>
                        </div>
                        <div class=""tab-content"">
                            <div class=""tab-pane active"" id=""tabUsers"">
                                <div class=""row column-seperation"">
                                    <div class=""col-md-6"">
                                        <table class=""table table-hover table-striped"">
                                            <thead>
                                                <tr>
   ");
            WriteLiteral(@"                                                 <th>
                                                        Secilib
                                                    </th>
                                                    <th>
                                                        User Adi
                                                    </th>
                                                </tr>
                                            </thead>
                                            <tbody>
");
#nullable restore
#line 73 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                 foreach (Tuple<int, string, bool> item in ViewBag.Users)
                                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                    <tr>\r\n                                                        <td>\r\n                                                            <label");
            BeginWriteAttribute("for", " for=\"", 3417, "\"", 3439, 2);
            WriteAttributeValue("", 3423, "user_", 3423, 5, true);
#nullable restore
#line 77 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
WriteAttributeValue("", 3428, item.Item1, 3428, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                                            <input type=\"checkbox\"");
            BeginWriteAttribute("id", "\r\n                                                                   id=\"", 3533, "\"", 3622, 2);
            WriteAttributeValue("", 3606, "user_", 3606, 5, true);
#nullable restore
#line 79 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
WriteAttributeValue("", 3611, item.Item1, 3611, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                                   data-user-id=\"");
#nullable restore
#line 80 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                            Write(item.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                                   data-role-id=\"");
#nullable restore
#line 81 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                            Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                                   ");
#nullable restore
#line 82 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                               Write(item.Item3 ? " checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n                                                        </td>\r\n                                                        <td>\r\n                                                            ");
#nullable restore
#line 85 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                       Write(item.Item2);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                        </td>\r\n                                                    </tr>\r\n");
#nullable restore
#line 88 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                            <div class=""tab-pane"" id=""tabClaims"">
                                <div class=""row"">
                                    <div class=""col-md-6"">
                                        <table class=""table table-hover table-striped"">
                                            <thead>
                                                <tr>
                                                    <th>
                                                        Secilib
                                                    </th>
                                                    <th>
                                                        Selahiyyet Adi
                                                    </th>
                                                </tr>
");
            WriteLiteral("                                            </thead>\r\n                                            <tbody>\r\n");
#nullable restore
#line 109 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                 if (ViewBag.Policies != null)
                                                {
                                                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 111 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                     foreach (Tuple<string, bool> item in ViewBag.Policies)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <tr>\r\n                                                            <td>\r\n                                                                <label");
            BeginWriteAttribute("for", " for=\"", 5911, "\"", 5952, 2);
            WriteAttributeValue("", 5917, "policy_", 5917, 7, true);
#nullable restore
#line 115 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
WriteAttributeValue("", 5924, item.Item1.Replace(".","_"), 5924, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></label>\r\n                                                                <input type=\"checkbox\"");
            BeginWriteAttribute("id", "\r\n                                                                       id=\"", 6050, "\"", 6162, 2);
            WriteAttributeValue("", 6127, "policy_", 6127, 7, true);
#nullable restore
#line 117 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
WriteAttributeValue("", 6134, item.Item1.Replace(".","_"), 6134, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                                                                       data-policy-name=\"");
#nullable restore
#line 118 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                                    Write(item.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                                       data-role-id=\"");
#nullable restore
#line 119 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                                Write(Model.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"\r\n                                                                       ");
#nullable restore
#line 120 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                                   Write(item.Item2 ? " checked" : "");

#line default
#line hidden
#nullable disable
            WriteLiteral(" />\r\n                                                            </td>\r\n                                                            <td>\r\n                                                                ");
#nullable restore
#line 123 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                           Write(item.Item1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                                            </td>\r\n                                                        </tr>\r\n");
#nullable restore
#line 126 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 126 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                     
                                                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            </tbody>
                                        </table>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>


");
            DefineSection("addjs", async() => {
                WriteLiteral(@"
    <script>
$(document).ready(function () {
    $('[id^=user_]').change(function (e) {
                let data = $(e.currentTarget).data();
                data.selected = $(e.currentTarget).is(':checked');
                $.ajax({
                    url: '");
#nullable restore
#line 149 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                     Write(Url.Action("SetRole"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: 'POST',
                    data: data,
                    success: function (response) {
                        if (response.error) {
                            toastr.error(response.message, 'Xeta!');

                            $(e.currentTarget).prop('checked', !data.selected);
                            return;
                        }


                        toastr.success(response.message, 'Ugur!');
                    },
                    error: function (response) {
                        $(e.currentTarget).prop('checked', !data.selected);
                        let isAuthenticated = ");
#nullable restore
#line 165 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                          Write(User.Identity.IsAuthenticated);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            if (!isAuthenticated){\r\n                                window.location.href = \'");
#nullable restore
#line 168 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                   Write(Url.Action("Details", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
                            }
                    }
                    });
    });

    $('[id^=policy_]').change(function (e) {
                let data = $(e.currentTarget).data();
        data.selected = $(e.currentTarget).is(':checked');

        console.log(data);
                $.ajax({
                    url: '");
#nullable restore
#line 180 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                     Write(Url.Action("SetPolicy"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: 'POST',
                    data: data,
                    success: function (response) {
                        if (response.error) {
                            toastr.error(response.message, 'Xeta!');

                            $(e.currentTarget).prop('checked', !data.selected);
                            return;
                        }


                        toastr.success(response.message, 'Ugur!');
                    },
                    error: function (response) {
                        $(e.currentTarget).prop('checked', !data.selected);
                        let isAuthenticated = ");
#nullable restore
#line 196 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                          Write(User.Identity.IsAuthenticated);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                            if (!isAuthenticated){\r\n                                window.location.href = \'");
#nullable restore
#line 199 "/Volumes/MySSD/01.Codes/01.VS/01.LessonsCodes/OganiApiProject/Ogani/Ogani.WebUI/Areas/Admin/Views/Roles/Details.cshtml"
                                                   Write(Url.Action("Details", Model.Id));

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n                            }\r\n                    }\r\n                });\r\n    });\r\n\r\n        });</script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OganiRole> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
